using MvcMultipleTable_Demo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcMultipleTable_Demo.ViewModel
{
    public class EmployeeViewModel
    {
        public IEnumerable<Employee> Employees { get; set; }/*IEnumerable is an interface that defines one method getenumerator.It is the base interface for all non generic collections */
        public IEnumerable<Department> Departments { get; set; }
        public IEnumerable<Incentive> Incentives { get; set; }

    }
}