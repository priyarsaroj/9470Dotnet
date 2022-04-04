using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndexOutOfRange_Exception
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] a = new int[3];
            try
            {
                Console.WriteLine("Enter the elements:");
                for (int i = 0; i < 3; i++)
                {
                    a[i] = Convert.ToInt32(Console.ReadLine());
                }
                Console.WriteLine("arr[0] = {0}", a[0]);
                Console.WriteLine("arr[1] = {0}", a[1]);
            }
            catch (IndexOutOfRangeException ie)
            {
                Console.WriteLine(ie.Message);
            }

            Console.ReadKey();
        }
    }
}
