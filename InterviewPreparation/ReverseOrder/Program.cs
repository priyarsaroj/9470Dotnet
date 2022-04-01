using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseOrder
{
    internal class Program
    {
        static void Main(string[] args)
        {
             int[] list = { 10, 100, 1000, 10000 };
            int[] temp = list;
            Console.Write("Original Array: ");
            foreach (int i in list)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
            // reverse the array
            Array.Reverse(temp);
            Console.Write("Reversed Array: ");
            foreach (int i in temp)
            {
                Console.Write(i + " ");
            }
            Console.ReadKey();
        }
    }
}
