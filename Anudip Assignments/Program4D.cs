using System;
class Test
{
    static void Main(string[] args)
    {
        string a = "Codes";
        string b = "Dope";
        int x = String.Compare(a, b);
        int y = String.Compare(b, a);
        Console.WriteLine(x);
        Console.WriteLine(y);
    }
}
