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
            int[] a = new int[2];
            try
            {
                Console.WriteLine("Enter the elements:");
                for (int i = 0; i < 2; i++)
                {
                    a[i] = Convert.ToInt32(Console.ReadLine());
                }
                Console.WriteLine("arr[2] = {0}", a[2]);
                Console.WriteLine("arr[3] = {0}", a[3]);
            }
            catch (IndexOutOfRangeException ie)
            {
                Console.WriteLine(ie.Message);
            }

            Console.ReadKey();
        }
    }
}
