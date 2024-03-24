using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practics
{
    class linq
    {
        static void Main()
        {
            /*
            int[] arr = { 23, 45, 56, 78, 54, 22, 56, 21, 45 };
            var brr = from i in arr where i > 50 orderby i descending select i;
            foreach( int i in brr)
                Console.Write(i+" ");

            StringBuilder sw = new StringBuilder("Janaki Ram");
            sw.Append(" Gadi");
            Console.WriteLine(sw);
            Console.ReadLine();
            */


            int[] brr = { 89, 67, -23, 11, 12, 13, -12, -1, -15 };
            int[] arr = new int[brr.Length];
            int a, b = 0, c = 0;
            for (int i = 0; i < brr.Length; i++)
            {
                a = brr[i];
                for (int j = 2; j < a; j++)
                {
                    if (a % j == 0)
                    {
                        c++;
                    }
                }
                if (c == 0)
                {
                    arr[b] = brr[i];
                    b++;
                }
            }
            int big = arr[0];
            for (int i = 1; i < b; i++)
            {
                if (arr[i] > big)
                {
                    big = arr[i];
                }
            }
            Console.WriteLine("The biggest prime number in the given number " + big);
            Console.ReadLine();

        }

    }
}
