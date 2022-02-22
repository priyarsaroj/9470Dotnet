using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Cookies
{
    public partial class _default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btncreatecookie_Click(object sender, EventArgs e)
        {
            Response.Cookies["name"].Value = txtcreatecookie.Text;
            Response.Cookies["name"].Expires = DateTime.Now.AddMinutes(1);
            Label1.Text = "Cookie Created";
            txtcreatecookie.Text = "";
        }

        protected void btnretrievecookie_Click(object sender, EventArgs e)
        {
            if (Request.Cookies["name"] == null)
            {
                txtretrievecookie.Text = "No cookie found";
            }
            else
            {
                txtretrievecookie.Text = Request.Cookies["name"].Value;
            }
        }
    }
}