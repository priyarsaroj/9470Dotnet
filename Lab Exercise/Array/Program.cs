using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array
{
    class Program
    {

        // Main Method
        public static void Main(string[] args)
        {

            // creating array
            int[] arr = new int[4];

            // initializing array
            arr[0] = 47;
            arr[1] = 77;
            arr[2] = 87;
            arr[3] = 97;

            // traversing array
            for (int i = 0; i < arr.Length; i++)
            {

                Console.WriteLine(arr[i]);
            }
        }
    }

}
