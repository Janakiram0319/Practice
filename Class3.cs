using System;
namespace Abstract
{
abstract class abc
    {
        int a=998;
        int b=888;
        internal void display()
        {
            Console.WriteLine("Sum of two numbers"+(a+b));
        }
        internal abstract void show();
    }
    class abcd:abc
    {
        internal override void show()
        {
            Console.WriteLine("Show is calling");
        }
    }
    class program
    {
        static void Main()
        {
            abc m = new abcd();
            m.display();
            m.show();
            Console.ReadLine();
        }
    }
}