﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication4
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            List<int> lst = new List<int>();
            lst.Add(100);
            lst.Add(200);
            lst.Add(300);
            lst.Add(400);
            foreach (int i in lst)
            {
                Response.Write(i + "<br>");
            }
        }
    }
}