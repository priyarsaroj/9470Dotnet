using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddTwoNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a, b;
            Console.WriteLine("Enter the first number:");
            a=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the second number:");
            b=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("The sum of two numbers is: {0}", (a+b));
        }
    }
}
