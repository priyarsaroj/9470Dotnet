using System;
namespace Practical5
{
    class Program
    {
        public static void Main(string[] args)
        {
         int[][] arr = new int[][]
         {
             new int[] { 0, 1 },
             new int[] { 10, 11 },
             new int[] { 100, 101, 110, 111 }
         };
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr[i].Length; j++)
                {
                    System.Console.Write(arr[i][j] + " ");
                }
                System.Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
