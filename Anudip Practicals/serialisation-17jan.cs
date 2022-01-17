using System;
using System.IO;
using System.Collections;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Soap;
namespace serialisation
{
    public static void Main()
    {
        try
        {
            secreteClass objSecrete = new secreteClass();
            objSecrete.MyAccNum = 123321456;

            //Soap serialization technique 
            SoapFormatter formatter = new SoapFormatter();
            Stream objfilestream = new FileStream("c:\\Myserialzed.xml", FileMode.Create, FileAccess.Write, FileShare.None);

            formatter.Serialize(objfilestream, objSecrete);
            objfilestream.Close();
            //deserialization 
            Stream objreadstream = new FileStream("c:\\Myserialzed.xml", FileMode.Open, FileAccess.Read, FileShare.Read);
            secreteClass objSecrete2 = (secreteClass)formatter.Deserialize(objreadstream);

            int Myaccno = objSecrete2.MyAccNum;
            Console.Writeln("AccNo:{0} " + Myaccno.ToString());
        }
        catch (Exception ex)
        { }
    }
    public class secreteClass
    {
        private int myaccountnumber = 0;

        private string password = "qwerty321";

        public int MyAccNum
        {
            get
            {
                return myaccountnumber;
            }
            set
            {
                myaccountnumber = value;
            }
        }
        public string Passwd
        {
            get
            {
                return password;
            }
            set
            {
                password = value;
            }
        }
        public secreteClass()
        {

        }
    }
}
