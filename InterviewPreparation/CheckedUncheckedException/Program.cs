using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckedUncheckedException
{
    internal class Program
    {
        static void Main(string[] args)
        {
            sbyte num1 = 20, num2 = 30, result;
            try
            {
                unchecked
                {
                    result = (sbyte)(num1 * num2);
                    Console.WriteLine("{0}x{1} = {2}", num1, num2, result);
                }
                checked
                {
                    result = (sbyte)(num1 * num2);
                    Console.WriteLine("{0}x{1} = {2}", num1, num2, result);
                }
            }
            catch (OverflowException oe)
            { 
                Console.WriteLine(oe.Message);
            }
            Console.ReadKey();
        }
    }
}
