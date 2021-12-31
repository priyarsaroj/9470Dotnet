using System;
using System.Text;
namespace object_Class_Gethashcode
{
    class Program
    {
        class HashC
        {
            string name;
            public HashC(string name)
            {
                this.name = name;
            }
            public override int GetHashCode()
            {
                string n = ToString();
                return n.GetHashCode();
            }

        }
        static void Main(string[] args)
        {
            HashC ob1 = new HashC("Priya Rajmani Saroj");
            Console.WriteLine(ob1.GetHashCode());
            Console.ReadLine();
        }
    }
}