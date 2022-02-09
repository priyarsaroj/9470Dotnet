using System;
using System.Linq;
class Program
{
    public static void Main()
    {
        int[] nums = { 6, -2, 30, -3, 0, -8, 12, 7, 8, 9, 100 };
        // Query for obtains positive values less than 10.
        var result = from n in nums
                     where n > 0
                     where n < 10
                     select n;
        Console.Write("The positive values less than 10: ");
        // Execute the query.
        foreach (int i in result)
        {
            Console.Write(i + " ");
        }
        Console.ReadLine();
    }
}
