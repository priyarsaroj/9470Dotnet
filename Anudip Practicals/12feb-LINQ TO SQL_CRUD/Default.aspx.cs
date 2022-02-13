using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Drawing;

namespace LinqToSql_CRUD
{
    public partial class Default : System.Web.UI.Page
    {
        StudentDataContext db = new StudentDataContext();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                BindGridview();
            }
        }
        protected void BindGridview()
        {
            var result = from ed in db.Students
                         select new
                         {
                             Id = ed.Id,
                             First_Name = ed.First_name,
                             Last_Name = ed.Last_name,
                             Address = ed.Address,
                             Phone_No = ed.Phone_No,
                         };
            GridView1.DataSource = result;
            GridView1.DataBind();
        }
        protected void GridView1_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName.Equals("AddNew"))
            {
                TextBox txtFirst_name = (TextBox)GridView1.FooterRow.FindControl("txtFirst_name");
                TextBox txtLast_name = (TextBox)GridView1.FooterRow.FindControl("txtLast_name");
                TextBox txtAddress = (TextBox)GridView1.FooterRow.FindControl("txtAddress");
                TextBox txtPhone_No = (TextBox)GridView1.FooterRow.FindControl("txtPhone_No");
                
                Student emp = new Student();

                emp.First_name = txtFirst_name.Text;
                emp.Last_name = txtLast_name.Text;
                emp.Address = txtAddress.Text;
                emp.Phone_No = txtPhone_No.Text;
               
                db.Students.InsertOnSubmit(emp);
                db.SubmitChanges();

                lblresult.ForeColor = Color.Green;
                lblresult.Text = txtFirst_name.Text + " details inserted successfully";
                BindGridview();
            }
        }
        protected void GridView1_RowEditing(object sender, GridViewEditEventArgs e)

        {
            GridView1.EditIndex = e.NewEditIndex;
            BindGridview();
        }

        protected void GridView1_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            GridView1.EditIndex = -1;
            BindGridview();
        }

        protected void GridView1_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            GridView1.PageIndex = e.NewPageIndex;
            BindGridview();
        }
        protected void GridView1_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            int Id = Convert.ToInt32(GridView1.DataKeys[e.RowIndex].Values["Id"].ToString());
            TextBox txtFirst_name = (TextBox)GridView1.Rows[e.RowIndex].FindControl("txtFirst_name");
            TextBox txtLast_name = (TextBox)GridView1.Rows[e.RowIndex].FindControl("txtLast_name");
            TextBox txtAddress = (TextBox)GridView1.Rows[e.RowIndex].FindControl("txtAddress");
            TextBox txtPhone_No = (TextBox)GridView1.Rows[e.RowIndex].FindControl("txtPhone_No");
            
            Student emp = new Student();

            emp = db.Students.Single(x => x.Id == Id);
            emp.First_name = txtFirst_name.Text;
            emp.Last_name = txtLast_name.Text;
            emp.Address = txtAddress.Text;
            emp.Phone_No = txtPhone_No.Text;
            
            db.SubmitChanges();
            
            GridView1.EditIndex = -1;
            BindGridview();
            lblresult.ForeColor = Color.Green;
            lblresult.Text = txtFirst_name.Text + " details updated successfully";
        }
        protected void GridView1_RowDeleting(object sender, GridViewDeleteEventArgs e)

        {
            int empid = Convert.ToInt32(GridView1.DataKeys[e.RowIndex].Values["Id"].ToString());
            string empname = GridView1.DataKeys[e.RowIndex].Values["Name"].ToString();

            Student emp = new Student();

            emp = db.Students.Single(x => x.Id == empid);

            db.Students.DeleteOnSubmit(emp);

            db.SubmitChanges();

            BindGridview();

            lblresult.ForeColor = Color.Green;

            lblresult.Text = emp.First_name + " details deleted successfully";

        }
    }
}
