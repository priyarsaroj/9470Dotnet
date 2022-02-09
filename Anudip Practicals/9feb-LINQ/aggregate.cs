using System;
using System.Linq;
class aggregate
{
    public static void Main()
    {
        int[] nums = { 10, 20, 30, 40, 50, 1, 2, 3, 4, 5 };
        Console.WriteLine("Total count = " + nums.Count());
        Console.WriteLine("Average     = " + nums.Average());
        Console.WriteLine("Summation   = " + nums.Sum());
        Console.WriteLine("Max value   = " + nums.Max());
        Console.WriteLine("Min Value   = " + nums.Min());
        Console.ReadLine();
    }
}
