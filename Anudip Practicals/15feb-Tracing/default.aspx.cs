using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Tracing2
{
    public partial class _default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //bind the grid view  
            //connection string  
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-50BB7SC;Initial Catalog=priya;Integrated Security=True");
            //write query  
            string query = "select * from employee2";
            SqlDataAdapter da = new SqlDataAdapter(query, con);
            DataSet ds = new DataSet();
            //fill in dataset  
            da.Fill(ds);
            GridView1.DataSource = ds;
            GridView1.DataBind();
        }
    }
}

        