using System;
using System.Collections.Generic;
using System.Linq;
class Employee1
{
    public int EmployeeID { get; set; }
    public string EmpName { get; set; }
    public int Age { get; set; }
}
class Program
{
    public static void Main()
    {
        List<Employee1> empList = new List<Employee1>()
        {
   new Employee1() { EmployeeID = 1, EmpName = "Raj", Age = 28 } ,
   new Employee1() { EmployeeID = 2, EmpName = "Rajesh",  Age = 28 } ,
   new Employee1() { EmployeeID = 3, EmpName = "Sunder",  Age = 35 } ,
   new Employee1() { EmployeeID = 4, EmpName = "Ram" , Age = 20 } ,
   new Employee1() { EmployeeID = 5, EmpName = "Ronit" , Age = 20 }
};
        var empResult = from s in empList group s by s.Age;
        foreach (var emp in empResult)
        {
            Console.WriteLine("Employee Age Group = " + emp.Key);
            foreach (Employee1 e in emp)
                Console.WriteLine("Employee1 Name: {0}", e.EmpName);
        }
    }
}