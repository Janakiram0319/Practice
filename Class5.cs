using System;
namespace Array
{
    class program
    {
        static void Main()
        {
            /*
            string s = "HELLO WORLD";
            char[] m = s.ToCharArray();
            for(int i = 0; i< s.Length; i++)
            {
                for(int j=i+1;j<s.Length;j++)
                {
                    if(s[i]==s[j])
                    {
                        m[i] = '0';
                        m[j] = '0';
                    }
                }
                if(m[i]!='0')
                {
                    Console.Write(m[i]);
                }
            }
            string s = "My name is ABC";
            int cnt = 0;
            for(int i=0;i<s.Length;i++)
            {
                if ((s[i] == 32)|| (i == s.Length-1))
                {
                    if (i == s.Length - 1)
                        i++;
                    for(int j=i-1;j>cnt-1;j--)
                    {
                        Console.Write(s[j]);
                    }
                    if(cnt==0)
                    {
                        Console.Write(" ");
                    }
                    cnt = i;
                }
            }
            
            int[] a = { 4, 5, 6, 89, 2,120,229 };
            int max = 0,t=0;
            for(int i=0;i<a.Length;i++)
            {
                if(a[i]>max)
                {
                    max = a[i];
                }
                if(max==a[i])
                {
                    t = i+1;
                }
            }
            Console.WriteLine("Maximum element is at position "+t+" and it's value is "+max);
            

            string a = "Desperation";
            string b = "A Rope Ends Itt";
            int[] e = new int[256];
            int[] w = new int[256];
            char[] m = a.ToCharArray();
            char[] n = b.ToCharArray();
            int  o=0,av=0;
            string []v = a.Split(' ');
            string[] p = b.Split(' ');
            if(v.Length==p.Length)
            {
                for(int i=0;i<a.Length;i++)
                {
                   
                    if(m[i]>=65&&m[i]<=90)
                    {
                        m[i] = (char)( m[i]+32);
                    }
                    av = (int)m[i];
                    e[av]++;
                }
                for(int i=0;i<b.Length;i++)
                {
                    
                    if (n[i] >= 65 && n[i] <= 90)
                    {
                        n[i] = (char) (n[i]+32);
                    }
                    av = (int)n[i];
                    w[av]++;
                }

                for(int i=0;i<e.Length;i++)
                {
                    if (e[i] != 0)
                    {
                        if (e[i] == w[i])
                        {
                            o=1;
                        }
                        else
                        {
                            Console.WriteLine("The two strings are not Anagram");
                            o = 0;
                            break;
                        }
                    }
                }
                if (o == 1) 
                        Console.WriteLine("The two strings are  Anagram");


                
            }
            else
            {
                Console.WriteLine("The two strings are not Anagram");
            }
            /*
            int[] a = { 12, 23, 11, 23, 21 ,12,11,12,10,12};
            int max = 0,t=0;
            for(int i=0;i<a.Length;i++)
            {
                for(int j=i+1;j<a.Length;j++)
                {
                        if(a[i]>max)
                        {
                            max = a[i];
                        }
                }
            }
            for(int i=0;i<a.Length;i++)
            {
                if (max == a[i])
                    t++;
            }
            Console.WriteLine("Highest number is "+max+" occurrence "+t);

            
            int[] a = { 3, 2, 0, 6, 0, 0, 1, 0, 5, 4 };
            int cnt = 0;
            for(int i=0;i<a.Length;i++)
            {
                if(a[i]!=0)
                {
                    a[cnt] = a[i];
                    cnt++;
                }
            }
            while(cnt<a.Length)
            {
                a[cnt] = 0;
                cnt++;
            }
            foreach(int b in a)
            {
                Console.Write(b);
            }

            int[] a = { 3, 2, 1, 5, 4, 6 };
            int min = a[0],sm=a[0],tm=a[0];
            for(int i=0;i<a.Length;i++)
            {
                if(a[i]<min)
                {
                    tm = sm;
                    sm = min;
                    min = a[i];
                }
                else if(a[i]<sm)
                {
                    tm = sm;
                    sm = a[i];
                }
                else if(a[i]<tm)
                {
                    tm = a[i];
                }
            }
            Console.WriteLine(min+" "+sm+" "+tm);
            
            int[] a = { 34, 12, 56, 12, 78, 34 };
            int[] b = new int[a.Length];
            int i, j, temp,cnt;
            for(i=0;i<a.Length;i++)
            {
                if(b[i]==0)
                {
                    temp = a[i];
                    cnt=0;
                    for(j=0;j<a.Length;j++)
                    {
                        if(a[i]==temp)
                        {
                            b[j] = 1;
                            cnt++;
                        }
                    }
                    Console.WriteLine(a[i]+" occur"+cnt+" times");
                }
            }
            
            int[] temp = { 73, 74, 75, 71, 69, 72, 76, 73 };
            int[] s = new int[temp.Length];
            for(int i=0;i<temp.Length;i++)
            {
                for(int j=i+1;j<temp.Length;j++)
                {
                    if(temp[i]<temp[j])
                    {
                        s[i] = temp[j] - temp[i];
                        break;
                    }
                }
            }

            
            
            string s = "i am janaki Ram";
            Console.WriteLine(s.Substring(5, 8));
            */
            int[] a = { 1, 3, 4, 5, 6, 6 };
            int max = 0;
            for(int i=0;i<a.Length;i++)
            {
                if (a[i] > max)
                    max = a[i];
            }
            int sum = 0;
            for (int i = 0; i < a.Length; i++)
            {
                for(int j=i;j<a.Length;j++)
                {
                    sum += a[j];
                }
                if (sum > max)
                    max = sum;
            }
            Console.WriteLine(sum);

            Console.ReadLine();
        }
    }
}