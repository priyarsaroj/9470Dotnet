/* Write a program to create two multidimensional arrays of same size.
   Accept value from user and store them in first array. 
   Now copy all the elements of first array are second array and print output.*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiDimensionalArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] arr1 = new int[3, 3];
            int[,] arr2 = new int[3, 3];
            int i, j;
            for (i = 0; i < 3; i++)
            {
                for (j = 0; j < 3; j++)
                {
                    Console.Write("Enter array value:\t");
                    arr1[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            for (i = 0; i < 3; i++)
            {
                for (j = 0; j < 3; j++)
                {
                    arr2[i, j] = arr1[i, j];
                }
            }

            Console.WriteLine("\n\nElements of second array are:\n\n");
            for (i = 0; i < 3; i++)
            {
                Console.WriteLine();
                for (j = 0; j < 3; j++)
                {
                    Console.Write("\t{0}", arr2[i, j]);
                }
            }
            Console.ReadLine();
        }
    }
}
