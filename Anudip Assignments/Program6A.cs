using System;
struct student
{
    public String fname, lname, address;
}
struct Marks
{
    public student s;
    public int math, sci, eng, phy, hin;
}
class nest
{
    public static void Main()
    {
        Marks m;
        m.s.fname = "Priya";
        m.s.lname = "Saroj";
        m.s.address = "Mumbai";
        m.math = 75;
        m.sci = 70;
        m.eng = 60;
        m.phy = 55;
        m.hin = 90;
        Console.WriteLine("First Name = " + m.s.fname);
        Console.WriteLine("Last Name = " + m.s.lname);
        Console.WriteLine("Address = " + m.s.address);
        Console.WriteLine("Maths = " + m.math);
        Console.WriteLine("Science = " + m.sci);
        Console.WriteLine("English = " + m.eng);
        Console.WriteLine("Physics = " + m.phy);
        Console.WriteLine("Hindi = " + m.hin);
    }
}
