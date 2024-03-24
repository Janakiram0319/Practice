using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practics
{
    class MethodOverriding
    {
        internal virtual void display()
        {
            Console.WriteLine("it is a Parent class");
        }
        internal void Show()
        {
            Console.WriteLine("Hello");
        }

    }
    class Abcd:MethodOverriding
    {
        internal override void display()
        {
            Console.WriteLine("it is a base class");
        }
        internal void ShowBase()
        {
            Console.WriteLine("Hello Janaki");
        }
    }
    class program
    {
        static void Main()
        {
            //MethodOverriding obj = new MethodOverriding();
            //obj.display();
            MethodOverriding obj1 = new Abcd();
            obj1.display();
            obj1.Show();
          //  obj1.ShowBase();
            Console.ReadLine();
        }
    }
}
