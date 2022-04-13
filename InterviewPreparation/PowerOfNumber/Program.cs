using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PowerOfNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double a,b;
            Console.WriteLine("Enter a number:");
            a =Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Give the Exponent :");
            b = Convert.ToInt32(Console.ReadLine());
            double value1 = Math.Pow(a, b);
            Console.WriteLine("Result : {0}", value1);
            Console.ReadLine();
        }
    }
}
