using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Validation_Controls
{
    public partial class Default : System.Web.UI.Page
    {
        protected void BtnSubmit_Click(object sender, EventArgs e)
        {
            if (Page.IsValid)
            {
                BtnSubmit.Text = "Data Submitted!";
            }
        }
    }
}