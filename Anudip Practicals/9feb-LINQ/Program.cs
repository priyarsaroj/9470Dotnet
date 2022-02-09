using System;
using System.Collections.Generic;
using System.Linq;
class Employee
{
    public int EmployeeID { get; set; }
    public string EmpName { get; set; }
    public int Age { get; set; }
}
class Program
{
    public static void Main()
    {
        List<Employee> empList = new List<Employee>()
        {
        new Employee() { EmployeeID = 1, EmpName = "Raj", Age = 28 } ,
        new Employee() { EmployeeID = 2, EmpName = "Rajesh",  Age = 16 } ,
        new Employee() { EmployeeID = 3, EmpName = "Sunder",  Age = 35 } ,
        new Employee() { EmployeeID = 4, EmpName = "Ram" , Age = 20 } ,
        new Employee() { EmployeeID = 5, EmpName = "Ronit" , Age = 38 }
        };

        var empResult = from s in empList
                        where s.Age > 12 && s.Age < 30 && s.EmpName.StartsWith("R") &&
                        s.EmpName.EndsWith("h")
                        select s.EmpName;
        foreach (var emp in empResult)
        {
            Console.WriteLine(emp);
        }
        Console.ReadLine();
    }
}