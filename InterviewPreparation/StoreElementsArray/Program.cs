using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreElementsArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int a;
            int[] arr = new int[5];
            Console.WriteLine("Enter elements in an array and print it:");
            //accepting value from user
            for (a = 0; a < 5; a++)
            {
            //storing value in and array
                arr[a] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("\n\n");
            //printing the value
            for (a = 0; a < 5; a++)
            {
                Console.WriteLine("{0}",arr[a]);
            }
            Console.ReadLine();
        }
    }
}
