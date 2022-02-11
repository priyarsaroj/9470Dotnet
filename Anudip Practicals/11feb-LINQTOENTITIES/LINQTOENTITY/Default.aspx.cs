using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LINQTOENTITY
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            if (!Page.IsPostBack)
            {
                BindGridData();
            }
        }
        private void BindGridData()
        {
            // Create the object of the Context defined in the constructor of the context class.
            priyaEntities1 db = new priyaEntities1();
            var result = from emp in db.EmployeeDetails1
                         select new
                         {
                             Id = emp.EmpId,
                             Name = emp.EmpName,
                             Location = emp.Location,
                             Gender = emp.Gender
                         };
            GridView1.DataSource = result.ToList();
            GridView1.DataBind();
        }
    }
}