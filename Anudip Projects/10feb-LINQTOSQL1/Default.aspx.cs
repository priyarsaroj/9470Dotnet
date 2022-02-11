﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LINQTOSQL
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            StudentDataContext sd = new StudentDataContext();
            StudentData student = (from s in sd.StudentDatas where s.RollNumber.ToString() == TextBox1.Text select s).FirstOrDefault();
            if (student == null)
            {
                Label2.Text = "No Record Found";
            }
            else
            {
                Label2.Text = "Record Found successfully";
                TextBox2.Text = student.StudentName;
                TextBox3.Text = student.FatherName;
                TextBox4.Text = student.MotherName;
            }
        }
    }
}

        