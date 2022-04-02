using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraySort
{
    internal class Program
    {
        static void printarray(int[] arr)
        {
            Console.WriteLine("\nElements of array:\n");
            foreach (int i in arr)
            {
                Console.WriteLine("\t{0}", i);
            }
        }
        static void Main(string[] args)
        {
            int[] arr = new int [5];
            int i;
            for (i = 0; i < 5; i++)
            {
                Console.Write("Enter number:\t");
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            Program.printarray(arr);
            Array.Sort(arr);
            Program.printarray(arr);
            Console.ReadLine();
        }
    }
}
