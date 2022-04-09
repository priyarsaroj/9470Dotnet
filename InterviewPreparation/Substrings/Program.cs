using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Substrings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a String : ");
            string inputString = Console.ReadLine();

            Console.WriteLine("All substrings for given string are : ");

            for (int i = 0; i < inputString.Length; ++i)
            {
                StringBuilder subString = new StringBuilder(inputString.Length - i);
                for (int j = i; j < inputString.Length; ++j)
                {
                    subString.Append(inputString[j]);
                    Console.Write(subString + " ");
                }
            }
            Console.ReadKey();
        }
    }
}

    

