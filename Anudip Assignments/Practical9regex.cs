using System;
using System.Collections.Generic;
using System.Linq;
using System.Text; 
using System.Text.RegularExpressions;

namespace RegularExpression1
{
    class Program
    {
        static void Main(string[] args)
        {
            Regex r = new Regex(@"^\+?\d{0,2}\-?\d{4,5}\-?\d{5,6}");

            string[] str = { "+91-9678967101", "9678967101", "+91-9678-967101", "+91-96789-67101", "+919678967101" };

            foreach (string s in str)
            {
                Console.WriteLine("{0} {1} a valid mobile number.", s,
                r.IsMatch(s) ? "is" : "is not");

            }
        }
    }
}
