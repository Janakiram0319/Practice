using System;
namespace Interface
{
    interface Iuser
    {
        string display(string a, string b);
    }
    public class user:Iuser
    {
        string a;
        string b;
        public string display(string a,string b)
        {
            this.a = a;
            this.b = b;
            string s = a +" "+ b;
            return s;
        }
    }
    class program
    {
        static void Main()
        {
            Iuser d = new user();
            Console.WriteLine(d.display("Janaki","Ram"));
            Console.ReadLine();
        }
    }
}