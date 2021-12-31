using System;
struct student
{
    public String name, last;
}
struct Marks
{
    public student s;
    public int math, sci;
}
class nest
{
    public static void Main()
    {
        Marks m;
        m.s.name = "Priya";
        m.s.last = "Saroj";
        m.math = 75;
        m.sci = 70;
        Console.WriteLine("Name = " + m.s.name);
        Console.WriteLine("Last Name = " + m.s.last);
        Console.WriteLine("Math Marks = " + m.math);
        Console.WriteLine("Science = " + m.sci);
    }
}