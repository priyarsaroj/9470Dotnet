using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication
{
    public partial class DeleteEmployee : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                BindGridData();
            }
        }
        public void BindGridData()
        {
            DataSet ds = new DataSet();
            ServiceReference1.EmployeeServiceClient client = new ServiceReference1.EmployeeServiceClient();
            ds = client.GetEmployeeRecords();
            grdEmployees.DataSource = ds;
            grdEmployees.DataBind();
        }

        protected void btnDelete_Click(object sender, EventArgs e)
        {
            ServiceReference1.EmployeeServiceClient client = new ServiceReference1.EmployeeServiceClient();

            ServiceReference1.Employee employee = new ServiceReference1.Employee();
            employee.EmpID = txtSearch.Text.Trim();
            string result = client.DeleteRecords(employee);

            if (result == "Record Deleted Successfully!")
            {
                BindGridData();
                lblSearchResult.Text = "Employee ID: " + txtSearch.Text.Trim() + "Deleted Successfully!";
            }
            else
            {
                lblSearchResult.Text = "Employee ID: " + txtSearch.Text.Trim() + "Not Found!";
            }
        }
    }
}