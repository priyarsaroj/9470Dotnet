using System;
struct str
{
    int a, b;
    public str(int x,int y)
    {
        Console.WriteLine("Enter a No.");
        a = Int32.Parse(Console.ReadLine());
        b = Int32.Parse(Console.ReadLine());
    }
    public int sum()
    {
        return (a + b);
    }
}
class student
{
    public static void Main()
    {
        str obj = new str();
        int c = obj.show();
        Console.WriteLine("Sum = "+c);
    }
}