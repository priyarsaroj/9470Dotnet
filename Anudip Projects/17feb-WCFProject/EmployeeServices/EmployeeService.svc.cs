using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace EmployeeServices
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IEmployeeService
    {
        public string GetData(int value)
        {
            return string.Format("You entered: {0}", value);
        }

        public string AddEmployyeeRecord(Employee emp)
        {
            string result = "";
            try
            {

                SqlConnection con = new SqlConnection("Data Source=DESKTOP-50BB7SC;Initial Catalog=priya;integrated Security=True");
                SqlCommand cmd = new SqlCommand();

                string Query = @"INSERT INTO tblEmployee (EmpID,Name,Email,Phone,Gender)  
                                               Values(@EmpID,@Name,@Email,@Phone,@Gender)";

                cmd = new SqlCommand(Query, con);
                cmd.Parameters.AddWithValue("@EmpID", emp.EmpID);
                cmd.Parameters.AddWithValue("@Name", emp.Name);
                cmd.Parameters.AddWithValue("@Email", emp.Email);
                cmd.Parameters.AddWithValue("@Phone", emp.Phone);
                cmd.Parameters.AddWithValue("@Gender", emp.Gender);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                result = "Record Added Successfully !";
            }
            catch (FaultException fex)
            {
                result = "Error";
            }

            return result;
        }

        //Retrieve Data  
        //Retrive Record  
        public DataSet GetEmployeeRecords()
        {
            DataSet ds = new DataSet();
            try
            {
                SqlConnection con = new SqlConnection("Data Source=DESKTOP-50BB7SC;Initial Catalog=priya;integrated Security=True");
                string Query = "SELECT * FROM tblEmployee";

                SqlDataAdapter sda = new SqlDataAdapter(Query, con);
                sda.Fill(ds);
            }
            catch (FaultException fex)
            {
                throw new FaultException<string>("Error: " + fex);
            }

            return ds;
        }

        //Delete Record  
        public string DeleteRecords(Employee emp)
        {
            string result = "";
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-50BB7SC;Initial Catalog=priya;integrated Security=True");
            SqlCommand cmd = new SqlCommand();
            string Query = "DELETE FROM tblEmployee Where EmpID=@EmpID";
            cmd = new SqlCommand(Query, con);
            cmd.Parameters.AddWithValue("@EmpID", emp.EmpID);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            result = "Record Deleted Successfully!";
            return result;
        }

        //Search Employee Record  
        public DataSet SearchEmployeeRecord(Employee emp)
        {
            DataSet ds = new DataSet();
            try
            {
                SqlConnection con = new SqlConnection("Data Source=DESKTOP-50BB7SC;Initial Catalog=priya;integrated Security=True");
                string Query = "SELECT * FROM tblEmployee WHERE EmpID=@EmpID";

                SqlDataAdapter sda = new SqlDataAdapter(Query, con);
                sda.SelectCommand.Parameters.AddWithValue("@EmpID", emp.EmpID);
                sda.Fill(ds);
            }
            catch (FaultException fex)
            {
                throw new FaultException<string>("Error:  " + fex);
            }
            return ds;
        }

        //UPDATE RECORDS  
        //Update by Phone Roll   
        public string UpdateEmployeeContact(Employee emp)
        {
            string result = "";
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-50BB7SC;Initial Catalog=priya;integrated Security=True");
            SqlCommand cmd = new SqlCommand();

            string Query = "UPDATE tblEmployee SET Email=@Email,Phone=@Phone WHERE EmpID=@EmpID";

            cmd = new SqlCommand(Query, con);
            cmd.Parameters.AddWithValue("@EmpID", emp.EmpID);
            cmd.Parameters.AddWithValue("@Email", emp.Email);
            cmd.Parameters.AddWithValue("@Phone", emp.Phone);
            con.Open();
            cmd.ExecuteNonQuery();
            result = "Record Updated Successfully !";
            con.Close();

            return result;
        }


    }
}  
    

