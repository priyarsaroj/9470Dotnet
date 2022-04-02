using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoopExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i=0, j=0;
            for (i = 0; i <= 5; i++) 
            {
                for (j = 0; j < i; j++)
                {
                    Console.Write(i);
                }
                Console.Write("\n");
            }
            Console.ReadLine();
        }
    }
}
