using System;
using System.Linq;
class SetOperator
{
    public static void Main()
    {
        string[] List1 = { "One", "Two", "three", "Four", "Six" };
        string[] List2 = { "Two", "THREE", "Four", "Five" };
        Console.WriteLine("Unique elements in both list\n");
        var result = List1.Union(List2);
        foreach (string str in result)
        {
            Console.WriteLine(str);
        }
        Console.WriteLine("\n Common elements in both list\n\n");
        var IntResult = List1.Intersect(List2);
        foreach (string str in IntResult)
        {
            Console.WriteLine(str);
        }
        Console.WriteLine("\n Element in list1 after minus from list2 \n");
        var ExceptResult = List1.Except(List2);
        foreach (string str in ExceptResult)
        {
            Console.WriteLine(str);
        }
        Console.ReadLine();
    }
}
