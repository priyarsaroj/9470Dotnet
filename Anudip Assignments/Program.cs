using System;
struct str
{
    int a, b;
    public void get()
    {
        Console.WriteLine("Enter a No.");
        a = Int32.Parse(Console.ReadLine());
        b = Int32.Parse(Console.ReadLine());
    }
    public void show()
    {
        int c = a + b;
        Console.WriteLine("Sum = " + c);
    }
}
class abc
{
    public static void Main()
    {
        str obj = new str();
        obj.get();
        obj.show();
    }
}