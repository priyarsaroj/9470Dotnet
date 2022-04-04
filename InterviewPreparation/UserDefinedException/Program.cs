using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserDefinedException
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a;
            Console.WriteLine("Welcome");
            a = Convert.ToInt32(Console.ReadLine());
            try
            {
                if (a == 8 || a < 8)
                {
                    Console.WriteLine("Congratulations you have got an {0}", a);
                    Console.ReadLine();
                }
                else
                {
                    throw (new OutOfStockException("OutOfStockException generated"));
                }
            }
            catch (OutOfStockException oe)
            {
                Console.WriteLine(oe.Message.ToString());
                Console.ReadLine();
            }
        }
    }
}
    //creating custom exception
    public class OutOfStockException : Exception 
    {
        public OutOfStockException(string message) : base(message)
        {
            
        }

    }
