using System;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
public class SerialTest
{
    public void SerializeNow()
    {
        ClassToSerialize[] c = new ClassToSerialize[3];
        c[0] = new ClassToSerialize();
        c[0].Name = "bipin";
        c[0].Age = 26;
        c[1] = new ClassToSerialize();
        c[1].Name = "abc";
        c[1].Age = 75;
        c[2] = new ClassToSerialize();
        c[2].Name = "pqr";
        c[2].Age = 50;
        ClassToSerialize.CompanyName = "xyz";
        File f = new File("temp.dat");
        Stream s = f.Open(FileMode.Create);
        BinaryFormatter b = new BinaryFormatter();
        b.Serialize(s, c);
        s.Close();
    }
    public void DeSerializeNow()
    {
        ClassToSerialize[] c;
        File f = new File("temp.dat");
        Stream s = f.Open(FileMode.Open);
        BinaryFormatter b = new BinaryFormatter();
        c = (ClassToSerialize[])b.Deserialize(s);
        Console.WriteLine("Name :" + c[2].Name);
        Console.WriteLine("Age :" + c[2].Age);
        Console.WriteLine("Company Name :" + ClassToSerialize.CompanyName);
        s.Close();
    }
    public static void Main(string[] s)
    {
        SerialTest st = new SerialTest();
        st.SerializeNow();
        st.DeSerializeNow();
    }
}
public class ClassToSerialize
{
    private int age;
    private string name;
    static string companyname;
    public int Age
    {
        get
        {
            return age;
        }
        set
        {
            age = value;
        }
    }
    public string Name
    {
        get
        {
            return name;
        }
        set
        {
            name = value;
        }
    }
    public static string CompanyName
    {
        get
        {
            return companyname;
        }
        set
        {
            companyname = value;
        }
    }
}