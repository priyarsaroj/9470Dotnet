using System;
public class Demo
{
    public static void Main()
    {
        object[] obj = new object[2];
        obj[0] = "pumpkin pie";
        obj[1] = 18;
        for (int i = 0; i < obj.Length; ++i)
        {
            string s = obj[i] as string;
            Console.Write("{0}: ", i);
            if (s != null)
                Console.WriteLine("'" + s + "'");
            else
                Console.WriteLine("This is not a string!");
        }
        Console.ReadKey();
    }
}
