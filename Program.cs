using System;
namespace program
{
    class abc
    {
        string a = "Janaki"; //private variables
        string b = "Ram";
        const string l = "Constant keyword";
        readonly string p;
        string email;
        internal string Email
        {
            get { return email; }
            set { email = value; }
        }
        internal void fullname() //instance method
        {
            string c = this.a + " " + this.b;
            Console.WriteLine(c);
            Console.WriteLine(l);
            Console.WriteLine(this.p);
        }
        internal long pinno()
        {
            long a = 8340956559;
            return a;
        }
        internal void sum(int k,int l) //parameterised instance method
        {
           
           int m = k + l;
            Console.WriteLine(m);

        }
        public abc(string p)
        {
            this.p = p;
            Console.WriteLine(p);
        }
        public abc() //constructor
        {
            Console.WriteLine("Hii");
        }
        private abc(int a,int b,int c)
        {
            Console.WriteLine("Private constructor");
        }
        internal abc(string d,string s) //parameterised constructor
        {
            string q = d +" "+ s;
            Console.WriteLine(q);
        }
        static abc() //static constructor
        {
            Console.WriteLine("Static Constructor");
        }
        static void all() //static method
        {
            abc m = new abc("Janaki Ram","Gadi");
            m.sum(67,87);
            m.fullname();
            Console.WriteLine( m.pinno());
        }
        static void Main() //main method
        {
            abc n = new abc("Swarnandhra","Mechanical");
            abc k = new abc("Readonly Constant");
            abc m = new abc(90,98,99);
            n.Email = "Janaki@gmail.com";
            n.fullname();
            Console.WriteLine(n.pinno());
           n.sum(778,999);
            abc.all();
           Console.WriteLine(n.Email = "Janaki@gmail.com");
            Console.ReadLine();
        }
    }
}