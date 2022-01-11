using System;
using System.Text.RegularExpressions;
namespace RegularExpression2
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "Hi,welcome@DotNet.com";

            string result = Regex.Replace(str, "[^a-zA-Z0-9_]+", " ");
            Console.WriteLine("is valid:{0}", result);
            Console.ReadLine();
        }
    }
}