using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseStringWithoutReverseFunction
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string Str, Revstr = ""; 
            int Length; 
            Console.Write("Enter a string : "); 
            Str = Console.ReadLine(); 
            Length = Str.Length - 1; 
            while (Length >= 0)  
            {
                Revstr = Revstr + Str[Length];  
                Length--;
            }
            Console.WriteLine("Reverse  string  is:  {0}", Revstr); 
            Console.ReadLine();
        }
    }
}
