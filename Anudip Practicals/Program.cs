using System;
namespace delegate_Example4
{
    class Program
    {
        public delegate void delmethod(int x, int y);
        public class TestMultipleDelegate
        {
            public void plus_Method1(int x, int y)
            {
                Console.Write("You are in plus_Method");
                Console.WriteLine(x + y);

}
            public void subtract_Method2(int x, int y)
            {
                Console.Write("You are in subtract_Method");
                Console.WriteLine(x - y);
            }
        }
        static void Main(string[] args)
        {
            TestMultipleDelegate obj = new TestMultipleDelegate();
            delmethod del = new delmethod(obj.plus_Method1);
           
            del += new delmethod(obj.subtract_Method2);
            
            del(50, 10);
            Console.WriteLine();
           
            del -= new delmethod(obj.plus_Method1);
           
            del(20, 10);
            Console.ReadLine();
        }
    }
}