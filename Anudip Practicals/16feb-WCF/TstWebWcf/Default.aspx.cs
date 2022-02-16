using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using TstWebWcf.ServiceReference1;

namespace TstWebWcf
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                DataTable dt = new DataTable();
                ServiceReference1.TstSIClient siclnt = new TstSIClient();
                dt = siclnt.GetRecordList();
                if (dt.Rows.Count > 0)
                {
                    grduser.DataSource = dt;
                    grduser.DataBind();
                }
            }
        }

        protected void btnSmt_click(object sender, EventArgs e)
        {
            ServiceReference1.TstSIClient siclnt = new TstSIClient();
            int tst = siclnt.CalculateSI(Convert.ToInt32(txtP.Text), Convert.ToInt32(txtR.Text), Convert.ToInt32(txtT.Text));
            lblval.Text = "Simple Interest : " + Convert.ToString(tst);
        }
    }
}