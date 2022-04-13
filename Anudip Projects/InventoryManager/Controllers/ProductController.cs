﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using InventoryBeginners.Data;
using InventoryBeginners.Models;
using System.Collections.Generic;
using System;
using System.Linq;
using InventoryBeginners.Interfaces;
using CodesByAniz.Tools;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Hosting;
using System.IO;

namespace InventoryBeginners.Controllers
{
    [Authorize]
    public class ProductController : Controller
    {
        private readonly IWebHostEnvironment _webHost;
        private readonly IBrand _brandRepo;
        private readonly ICategory _categoryRepo;
        private readonly IProductGroup _productgroupRepo;
        private readonly IProductProfile _productprofileRepo;
        private readonly IUnit _unitRepo;
        private readonly IProduct _productRepo;
        public ProductController(IWebHostEnvironment webHost,IBrand brandrepo, ICategory categoryrepo, IProductGroup productgrouprepo, IProductProfile productprofilerepo,IProduct productrepo,IUnit unitrepo) // here the repository will be passed by the dependency injection.
        {
             _webHost = webHost;
            _brandRepo = brandrepo;
            _categoryRepo = categoryrepo;
            _productgroupRepo = productgrouprepo;
            _productprofileRepo = productprofilerepo;
            _productRepo = productrepo;
            _unitRepo = unitrepo;

        }


        public IActionResult Index(string sortExpression = "", string SearchText = "", int pg = 1, int pageSize = 5)
        {
            SortModel sortModel = new SortModel();
            sortModel.AddColumn("Code");
            sortModel.AddColumn("name");
            sortModel.AddColumn("description");
            sortModel.AddColumn("Cost");
            sortModel.AddColumn("Price");
            sortModel.AddColumn("Unit");
            sortModel.ApplySort(sortExpression);
            ViewData["sortModel"] = sortModel;

            ViewBag.SearchText = SearchText;

            PaginatedList<Product> products = _productRepo.GetItems(sortModel.SortedProperty, sortModel.SortedOrder, SearchText, pg, pageSize);


            var pager = new PagerModel(products.TotalRecords, pg, pageSize);
            pager.SortExpression = sortExpression;
            this.ViewBag.Pager = pager;


            TempData["CurrentPage"] = pg;


            return View(products);
        }
   
        private void PopulateViewbags()
        {
            ViewBag.Units = GetUnits();
            ViewBag.Brands = GetBrands();
            ViewBag.Categories = GetCategories();
            ViewBag.ProductGroups = GetProductGroups();
            ViewBag.ProductProfiles = GetProductProfiles();
        }

        public IActionResult Create()
        {
            Product product = new Product();
            PopulateViewbags();
            return View(product);
        }

        [HttpPost]
        public IActionResult Create(Product product)
        {
            bool bolret = false;
            string errMessage = "";
            try
            {
                if (product.Description.Length < 4 || product.Description == null)
                    errMessage = "Product Description Must be atleast 4 Characters";

                if (_productRepo.IsItemCodeExists(product.Code) == true)
                    errMessage = errMessage + " " + " Product Code " + product.Code + " Exists Already";

                if (_productRepo.IsItemExists(product.Name) == true)
                    errMessage = errMessage + " " + " Product Name " + product.Name + " Exists Already";

                if (errMessage == "")
                {
                    string uniqueFileName = GetUploadedFileName(product);
                    product.PhotoUrl = uniqueFileName;
                    product = _productRepo.Create(product);
                    bolret = true;
                }
            }
            catch (Exception ex)
            {
                errMessage = errMessage + " " + ex.Message;
            }
            if (bolret == false)
            {
                TempData["ErrorMessage"] = errMessage;
                ModelState.AddModelError("", errMessage);
                PopulateViewbags();
                return View(product);
          
            }
            else
            {
                TempData["SuccessMessage"] = "Product " + product.Name + " Created Successfully";
                return RedirectToAction(nameof(Index));
            }
        }

        public IActionResult Details(string id) //Read
        {
            Product product = _productRepo.GetItem(id);
            ViewBag.Units = GetUnits();
            TempData.Keep();
            return View(product);
        }


        public IActionResult Edit(string id)
        {
            Product product = _productRepo.GetItem(id);
            ViewBag.Units = GetUnits();
            ViewBag.Units = GetUnits();
            ViewBag.Brands = GetBrands();
            ViewBag.Categories = GetCategories();
            ViewBag.ProductGroups = GetProductGroups();
            ViewBag.ProductProfiles = GetProductProfiles();
            TempData.Keep();
            return View(product);
        }

        [HttpPost]
        public IActionResult Edit(Product product)
        {
            bool bolret = false;
            string errMessage = "";

            try
            {
                if (product.Description.Length < 4 || product.Description == null)
                    errMessage = "Product Description Must be atleast 4 Characters";

                if (_productRepo.IsItemCodeExists(product.Name, product.Code) == true)
                    errMessage = errMessage + " " + " Product Code " + product.Code + " Exists Already";

                if (_productRepo.IsItemExists(product.Name, product.Code) == true)
                    errMessage = errMessage + "Product Name " + product.Name + " Already Exists";

                if(product.ProductPhoto != null)
                {
                    string uniqueFileName = GetUploadedFileName(product);
                    product.PhotoUrl = uniqueFileName;
                }
                    

                if (errMessage == "")
                {
                    product = _productRepo.Edit(product);
                    TempData["SuccessMessage"] = product.Name + ", Product Saved Successfully";
                    bolret = true;
                }
            }
            catch (Exception ex)
            {
                errMessage = errMessage + " " + ex.Message;
            }



            int currentPage = 1;
            if (TempData["CurrentPage"] != null)
                currentPage = (int)TempData["CurrentPage"];


            if (bolret == false)
            {
                TempData["ErrorMessage"] = errMessage;
                ModelState.AddModelError("", errMessage);
                return View(product);
            }
            else
                return RedirectToAction(nameof(Index), new { pg = currentPage });
        }

        public IActionResult Delete(string id)
        {
            Product product = _productRepo.GetItem(id);
            TempData.Keep();
            return View(product);
        }


        [HttpPost]
        public IActionResult Delete(Product product)
        {
            try
            {
                product = _productRepo.Delete(product);
            }
            catch (Exception ex)
            {
                string errMessage = ex.Message;
                if(ex.InnerException!=null)
                    errMessage = ex.InnerException.Message;
                TempData["ErrorMessage"] = errMessage;
                ModelState.AddModelError("", errMessage);
                return View(product);
            }

            int currentPage = 1;
            if (TempData["CurrentPage"] != null)
                currentPage = (int)TempData["CurrentPage"];

            TempData["SuccessMessage"] = "Product " + product.Name + " Deleted Successfully";
            return RedirectToAction(nameof(Index), new { pg = currentPage });


        }

        private List<SelectListItem> GetUnits()
        {
            var lstUnits = new List<SelectListItem>();

            PaginatedList<Unit> units = _unitRepo.GetItems("Name", SortOrder.Ascending,"",1,1000);
            lstUnits = units.Select(ut => new SelectListItem()
            {
                Value = ut.Id.ToString(),
                Text = ut.Name
            }).ToList();

            var defItem = new SelectListItem()
            {
             Value="",
             Text="----Select Unit----"
            };

            lstUnits.Insert(0, defItem);

            return lstUnits;
        }

        private List<SelectListItem> GetBrands()
        {
            var lstItems = new List<SelectListItem>();

            PaginatedList<Brand> items = _brandRepo.GetItems("Name", SortOrder.Ascending, "", 1, 1000);
            lstItems = items.Select(ut => new SelectListItem()
            {
                Value = ut.Id.ToString(),
                Text = ut.Name
            }).ToList();

            var defItem = new SelectListItem()
            {
                Value = "",
                Text = "----Select Brand----"
            };

            lstItems.Insert(0, defItem);

            return lstItems;
        }

        private List<SelectListItem> GetCategories()
        {
            var lstItems = new List<SelectListItem>();

            PaginatedList<Category> items = _categoryRepo.GetItems("Name", SortOrder.Ascending, "", 1, 1000);
            lstItems = items.Select(ut => new SelectListItem()
            {
                Value = ut.Id.ToString(),
                Text = ut.Name
            }).ToList();

            var defItem = new SelectListItem()
            {
                Value = "",
                Text = "----Select Category----"
            };

            lstItems.Insert(0, defItem);

            return lstItems;
        }

        private List<SelectListItem> GetProductGroups()
        {
            var lstItems = new List<SelectListItem>();

            PaginatedList<ProductGroup> items = _productgroupRepo.GetItems("Name", SortOrder.Ascending, "", 1, 1000);
            lstItems = items.Select(ut => new SelectListItem()
            {
                Value = ut.Id.ToString(),
                Text = ut.Name
            }).ToList();

            var defItem = new SelectListItem()
            {
                Value = "",
                Text = "----Select ProductGroup----"
            };

            lstItems.Insert(0, defItem);

            return lstItems;
        }

        private List<SelectListItem> GetProductProfiles()
        {
            var lstItems = new List<SelectListItem>();

            PaginatedList<ProductProfile> items = _productprofileRepo.GetItems("Name", SortOrder.Ascending, "", 1, 1000);
            lstItems = items.Select(ut => new SelectListItem()
            {
                Value = ut.Id.ToString(),
                Text = ut.Name
            }).ToList();

            var defItem = new SelectListItem()
            {
                Value = "",
                Text = "----Select ProductProfile----"
            };

            lstItems.Insert(0, defItem);

            return lstItems;
        }

        private string GetUploadedFileName(Product product)
        {
            string uniqueFileName = null;
            if (product.ProductPhoto != null)
            {
                string uploadsFolder = Path.Combine(_webHost.WebRootPath, "images");
                uniqueFileName = Guid.NewGuid().ToString() + "_" + product.ProductPhoto.FileName;
                string filePath = Path.Combine(uploadsFolder, uniqueFileName);
                using (var fileStream = new FileStream(filePath, FileMode.Create))
                {
                    product.ProductPhoto.CopyTo(fileStream);
                }
            }
            return uniqueFileName;
        }

    }
}
