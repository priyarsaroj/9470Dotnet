using System;
namespace Practical2
{
    class Program
    {
        public static void Main(string[] args)
        {
            string[] arr = new string[] { "C++", "Java", "C#" };
            foreach (string a in arr)
            {
                Console.WriteLine(a);
            }
               Console.ReadLine();
        }
    }
}