using System;
namespace Practical1
{
    public class Program
    {
        public static void Main(string[] args)
        {
         int[] arr = { 10, 11, 100, 101, 110 };
            int len = arr.Length;
            Console.WriteLine("Length of Array " + len);
            Console.WriteLine(arr[0] + " " + arr[4]);
        }
    }
}
