using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PyramidNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i, j, a, rows, k, t = 1;
            Console.Write("input number of rows : ");
            rows = Convert.ToInt32(Console.ReadLine());
            a = rows + 4 - 1;  // spc space
            for (i = 1; i <= rows; i++)
            {
                for (k = a; k >= 1; k--)
                {
                    Console.Write(" ");
                }
                for (j = 1; j <= i; j++)
                    Console.Write("{0} ", t++);
                Console.Write("\n");
                a--;
            }
        }
    }
}
