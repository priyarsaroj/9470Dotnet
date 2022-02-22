using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Xml.Linq;

namespace REST_WCF_Service
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "EmployeeService" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select EmployeeService.svc or EmployeeService.svc.cs at the Solution Explorer and start debugging.
    public class EmployeeService : IEmployeeService
    {
        public EmployeeDataContract GetEmployeeDetails(string EmpId)
        {
            EmployeeDataContract emp = new EmployeeDataContract();

            try
            {
                XDocument doc = XDocument.Load("D:\\Pictures\\Priya\\Anudip Priya\\Dot net\\WpfApplication1\\WpfApplication1\\EmployeeData.xml");

                IEnumerable<XElement> employee =
                    (from result in doc.Descendants("DocumentElement").Descendants("Employees")
                     where result.Element("EmployeeID").Value == EmpId.ToString()
                     select result);

                emp.EmployeeID = employee.ElementAt(0).Element("EmployeeID").Value;
                emp.Name = employee.ElementAt(0).Element("Name").Value;
                emp.JoiningDate = employee.ElementAt(0).Element("JoiningDate").Value;
                emp.CompanyName = employee.ElementAt(0).Element("CompanyName").Value;
                emp.Address = employee.ElementAt(0).Element("Address").Value; 
            }
            catch (Exception ex)
            {
                throw new FaultException<string>
                        (ex.Message);
            }
            return emp;
        }

        public bool AddNewEmployee(EmployeeDataContract employee)
        {
            try
            {
                XDocument doc = XDocument.Load("D:\\Pictures\\Priya\\Anudip Priya\\Dot net\\WpfApplication1\\WpfApplication1\\EmployeeData.xml");

                doc.Element("DocumentElement").Add(
                        new XElement("Employees",
                        new XElement("EmployeeID", employee.EmployeeID),
                        new XElement("Name", employee.Name),
                        new XElement("JoiningDate", employee.JoiningDate),
                        new XElement("CompanyName", employee.CompanyName),
                        new XElement("Address", employee.Address)));

                doc.Save("D:\\Pictures\\Priya\\Anudip Priya\\Dot net\\WpfApplication1\\WpfApplication1\\EmployeeData.xml");
            }
            catch (Exception ex)
            {
                throw new FaultException<string>
                        (ex.Message);
            }
            return true;
        }

        public void UpdateEmployee(EmployeeDataContract employee)
        {
            try
            {
                XDocument doc = XDocument.Load("D:\\Pictures\\Priya\\Anudip Priya\\Dot net\\WpfApplication1\\WpfApplication1\\EmployeeData.xml");
                var target = doc
                     .Element("DocumentElement")
                     .Elements("Employees")
                     .Where(e => e.Element("EmployeeID").Value == employee.EmployeeID)
                     .Single();

                target.Element("Name").Value = employee.Name;
                target.Element("JoiningDate").Value = employee.JoiningDate;
                target.Element("CompanyName").Value = employee.CompanyName;
                target.Element("Address").Value = employee.Address;

                doc.Save("D:\\Pictures\\Priya\\Anudip Priya\\Dot net\\WpfApplication1\\WpfApplication1\\EmployeeData.xml");
            }
            catch (Exception ex)
            {
                throw new FaultException<string>
                        (ex.Message);
            }
        }

        public void DeleteEmployee(string EmpId)
        {
            try
            {
                XDocument doc = XDocument.Load("D:\\Pictures\\Priya\\Anudip Priya\\Dot net\\WpfApplication1\\WpfApplication1\\EmployeeData.xml");
                foreach (var result in doc.Descendants("DocumentElement").Descendants("Employees"))
                {
                    if (result.Element("EmployeeID").Value == EmpId.ToString())
                    {
                        result.Remove();
                        break;
                    }
                }
                doc.Save("D:\\Pictures\\Priya\\Anudip Priya\\Dot net\\WpfApplication1\\WpfApplication1\\EmployeeData.xml");
            }
            catch (Exception ex)
            {
                throw new FaultException<string>
                        (ex.Message);
            }
        }
    }
}
