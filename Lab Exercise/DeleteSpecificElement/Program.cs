using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeleteSpecificElement
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            int pos = 0;
            int[] arr = new int[10];
            Console.WriteLine("Enter numbers : ");
            for (i = 0; i < 5; i++)
            {
                Console.Write("Element[" + (i + 1) + "]: ");
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.Write("Enter position to delete item : ");
            pos = Convert.ToInt32(Console.ReadLine());
            for (i = pos - 1; i < 5; i++)
            {
                arr[i] = arr[i + 1];
            }

            Console.WriteLine("Array elements after deletion : ");
            for (i = 0; i < 4; i++)
            {
                Console.WriteLine("Element[" + (i + 1) + "]: " + arr[i]);
            }

            Console.WriteLine();
        }
    }
}
