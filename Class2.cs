using System;
namespace Poly
{
    //function overloading or method overloading

    //class abc
    //{
    //    internal void add(int a, int b)
    //    {
    //        Console.WriteLine("Sum of two numbers are " + (a + b));
    //    }
    //    internal void add(int a, int b, int c)
    //    {
    //        Console.WriteLine("Sum of three numbers are " + (a + b + c));
    //    }
    //    internal void add(int a, int b, int c, int d)
    //    {
    //        Console.WriteLine("Sum of four numbers are " + (a + b + c + d));
    //    }

    //    static void Main()
    //    {
    //        abc obj = new abc();
    //        obj.add(2, 5);
    //        obj.add(65, 66, 77);
    //        obj.add(98, 87, 54, 33);
    //        Console.ReadLine();
    //    }
    //}
    //class program
    //{
    //    static void Main()
    //    {
    //        abc obj = new abc();
    //        obj.add(2, 5);
    //        obj.add(65, 66, 77);
    //        obj.add(98, 87, 54, 33);
    //        Console.ReadLine();
    //    }
    //}

    class abc
    {
        internal virtual void display()
        {
            Console.WriteLine("Abc display is calling");
        }
    }

    class abcd : abc
    {
        internal override void display()
        {
            Console.WriteLine("Abcd display is calling ");
        }
    }

    class Program
    {
        static void Main()
        {
            abc obj = new abc();
            obj.display();
            abc obj1 = new abcd();
            obj1.display();

            Console.ReadLine();
        }
    }

}
