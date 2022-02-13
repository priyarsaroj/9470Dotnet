﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LinqToAdo.Net_2
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                BindGridview();
            }
        }
        protected void BindGridview()
        {
            DataSet ds = new DataSet();
            using (SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-50BB7SC;Integrated Security=true;Initial Catalog=priya"))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("select * from Student", con);
                cmd.CommandType = CommandType.Text;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(ds);
                con.Close();
                if (ds.Tables[0].Rows.Count > 0)
                {
                    var result = from dt in ds.Tables[0].AsEnumerable()
                                 where dt.Field<string>("Last_name") == "Green"
                                 select new
                                 {
                                     First_name = dt.Field<string>("First_name"),
                                     Last_name = dt.Field<string>("Last_name"),
                                     Address = dt.Field<string>("Address"),
                                     Phone_No= dt.Field<string>("Phone_No"),
                                 };
                    GridView1.DataSource = result;
                    GridView1.DataBind();
                }
            }
        }
    }
}
