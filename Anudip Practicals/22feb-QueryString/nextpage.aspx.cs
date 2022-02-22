using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace QueryString
{
    public partial class nextpage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnretrievevalue_Click(object sender, EventArgs e)
        {
            Label1.Text = "Name = " + Request.QueryString["name"].ToString();
            Label2.Text = "City = " + Request.QueryString["city"].ToString();
        }
    }
}