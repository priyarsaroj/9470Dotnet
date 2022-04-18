using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConversionDollarsToRupees
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter dollars:");
            double dollars = Convert.ToDouble(Console.ReadLine());
            double rupees = dollars * 64;
            Console.WriteLine(rupees + " Rupees");
        }
    }
}
