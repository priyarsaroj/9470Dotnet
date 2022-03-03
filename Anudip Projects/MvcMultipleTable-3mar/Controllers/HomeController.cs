using MvcMultipleTable_Demo.Models;
using MvcMultipleTable_Demo.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcMultipleTable_Demo.Controllers
{
    public class HomeController : Controller
    {
        /*Readonly is a modifier which indicates the assignment to the field can only occur as a part of declaration or constructor in the same class*/
        private readonly EmployeeContext db = new EmployeeContext();
        public ActionResult Index()
        {
            var tables = new EmployeeViewModel
            {
                Employees = db.Employees.ToList(),
                Departments = db.Departments.ToList(),
                Incentives = db.Incentives.ToList()
            };
            return View(tables);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}
    
