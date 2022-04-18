using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PowerOfNumberWithoutMathFunc
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int baseNumber, expNumber, result = 1;
            Console.Write("Enter a Base Number : ");
            baseNumber = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter a exponent Number : ");
            expNumber = Convert.ToInt32(Console.ReadLine());


            while (expNumber != 0)
            {
                result *= baseNumber;
                --expNumber;
            }

            Console.WriteLine("Result = {0}", result);

            Console.ReadLine();
        }
    }
}
