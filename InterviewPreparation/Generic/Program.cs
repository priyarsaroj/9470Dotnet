using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic
{
    //declare generics
    public class GenericClass<T>
    {
        public void Genericfunction(T printvalue)
        {
            Console.WriteLine(printvalue);
        }
    }
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Printing integer value:");
            GenericClass<int> i = new GenericClass<int>();
            i.Genericfunction(100);
            Console.WriteLine("Printing string value:");
            GenericClass<string> s = new GenericClass<string>();
            s.Genericfunction("Priya");

        }
    }
}
