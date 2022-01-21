using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace A

{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            ArrayList al = new ArrayList();
            string str = "priya rajmani saroj";
            int x = 7;
            DateTime d = DateTime.Parse("12-jan-2022");
            al.Add(str);
            al.Add(x);
            al.Add(d);

            foreach (object o in al)
            {
                Response.Write(o);
                Response.Write("<br>");
            }
        }
    }
}
