using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvenOdd
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num;
            Console.Write("Enter a number:\t");
            num = Convert.ToInt32(Console.ReadLine());
            if (num % 2==0) 
            {
                Console.WriteLine("{0} is even number", num);
            }
            else
            {
                Console.WriteLine("{0} is odd number", num);
            }
            Console.ReadLine();
        }
    }
}
