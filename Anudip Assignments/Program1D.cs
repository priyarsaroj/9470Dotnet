using System;
namespace Practical3
{
    class Program
    {
        public static void Main(string[] args)
        {
            int i, j;
            int[,] arr = new int[2, 2];
            Console.WriteLine("Enter the elements for 2 X 2 matrix");
            for (i = 0; i < 2; i++)
            {
                for (j = 0; j < 2; j++)
                {
                    Console.Write("Enter element at [{0},{1}] = ", i, j);
                    arr[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            for (i = 0; i < 2; i++)
            {
                Console.Write("\n");
                for (j = 0; j < 2; j++)
                {
                    Console.Write("{0}\t", arr[i, j]);
                }
            }
        }
    }
}
