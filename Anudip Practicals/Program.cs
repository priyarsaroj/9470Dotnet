using System;
using System.Text.RegularExpressions;
namespace RegularExpression2
{
    class Program
    {
        static void Main(string[]args)
        {
            Console.WriteLine("Hello World!");
            string email = "priyasaroj202@gmail.com";
            var result = Regex.IsMatch(email, @"^[\w-\.]+@([\w-]+\.)+[\w-]{2,4}$");
            Console.WriteLine("is valid:{0}",result);
            Console.ReadLine();
        }
    }
}