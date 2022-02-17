using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication
{
    public partial class DisplayEmployeeRecord : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                DataSet ds = new DataSet();
               ServiceReference1.EmployeeServiceClient client = new ServiceReference1.EmployeeServiceClient();
                ds = client.GetEmployeeRecords();
                grdEmployees.DataSource = ds;
                grdEmployees.DataBind();
            }
        }
    }
}