using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebApplication.ServiceReference1;

namespace WebApplication
{
    public partial class AddNewEmployee : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                txtEmpID.Text = "";
                txtName.Text = "";
                txtEmail.Text = "";
                txtPhone.Text = "";
                lblMsg.Text = "";
                txtEmpID.Focus();
            }
        }

        protected void btnSave_Click(object sender, EventArgs e)
        {
            if ((txtEmpID.Text != "") || (txtName.Text != "") || (txtEmail.Text != "") || (txtPhone.Text != ""))
            {
                try
                {
                    ServiceReference1.Employee employee = new ServiceReference1.Employee();
                    employee.EmpID = txtEmpID.Text;
                    employee.Name = txtName.Text;
                    employee.Email = txtEmail.Text;
                    employee.Phone = txtPhone.Text;
                    employee.Gender = rbtnGender.SelectedItem.Text;

                    ServiceReference1.EmployeeServiceClient client = new ServiceReference1.EmployeeServiceClient();
                    lblMsg.Text = "Employee ID: " + employee.EmpID + ", " + client.AddEmployyeeRecord(employee);
                }
                catch (Exception )
                {
                    lblMsg.Text = "Employee ID must be unique! ";
                }


            }
            else
            {

                lblMsg.Text = "All fields are mandatory! ";
                lblMsg.ForeColor = System.Drawing.Color.Red;
            }


        }

        protected void bntReset_Click(object sender, EventArgs e)
        {
            ClearForm();
        }

        private void ClearForm()
        {
            txtEmpID.Text = "";
            txtName.Text = "";
            txtEmail.Text = "";
            txtPhone.Text = "";
            lblMsg.Text = "";
            txtEmpID.Focus();
        }
    }
    }
