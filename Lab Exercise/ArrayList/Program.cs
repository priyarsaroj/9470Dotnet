using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array_List
{
    class Program
    {

        // Main Method
        public static void Main(string[] args)
        {

            // Create a list of strings
            ArrayList al = new ArrayList();
            al.Add("Priyanka");
            al.Add("Nimesh");
            al.Add(1);
            al.Add(6.5);

            // Iterate list element using foreach loop
            foreach (var names in al)
            {
                Console.WriteLine(names);
            }
        }
    }

}
