using System;
namespace practice
{
        //single level inheritance
        /*
        class abc
        {
            internal string s;
            internal string g;
           internal int a = 98;
           internal int b = 809;
            internal void name(string m,string n)
            {
                s = m;
                g = n;
                string q =s + " " + g;
                Console.WriteLine(q);
            }

      
        class abcd:abc
        {
            internal string i = "Gadi";
           internal void Fullname()
            {
                int c = base.a + base.b;
                Console.WriteLine(c);
            }
        }
        class program
        {
            static void Main()
            {
                abc m = new abcd();
                m.name("Janaki","Ram");
                abcd b = new abcd();
                b.Fullname();
                Console.ReadLine();

            }
        }
        */
        
        //mutli level inheritance
       /* class abc
        {
             internal string q = "One";
            internal void display()
            {
                Console.WriteLine("abc is calling");
            }
        }
        class abcd:abc
        {
            internal string b = "two";
            internal void display1()
            {
                Console.WriteLine("abcd is calling"+q);
            }
        }
        class abcde:abcd
        {
            internal void display2()
            {
                Console.WriteLine("abcde is calling"+b);
            }
        }
        class program
        {
            static void Main()
            {
                abc k = new abc();
                k.display();
                abcd m = new abcd();
                m.display1();
                abcde o = new abcde();
                o.display2();
                Console.ReadLine();
            }
        }
       //Heiarchial inheritance
       class abc
        {
            internal string q = "Hii";
           internal string e = "Bye";
            internal static string p = "Static";
            internal void display()
            {
                Console.WriteLine(p);
            }
        }
        class abcd : abc
        {
            internal void display1()
            {
                Console.WriteLine(q);
            }
        }
        class abcde : abc
        {
            internal void display2()
            {
                Console.WriteLine(e);
            }
        }
        class program
        {
            static void Main()
            {
                abc n = new abc();
                n.display();
                abcd q = new abcd();
                q.display1();
                abcde w = new abcde();
                w.display2();
                Console.ReadLine();

            }
        }
       */
        class class1
        {
            public void Hello()
            {
                Console.WriteLine("Hello 1");
            }
        }
        static class class2
        {
            public static void Hello2(this class1 c1)
            {
                Console.WriteLine("Hello 2");
            }
        }
        class program
        {
            static void Main()
            {
                class1 c2 = new class1();
                c2.Hello();
                c2.Hello2();
                Console.ReadLine();
            }
        }
    
}