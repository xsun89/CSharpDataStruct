using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;

namespace KMP
{
    class Program
    {
        static void Main(string[] args)
        {
            string s1 = "abbbdchfdghjsdssafksdfsd";
            string s2 = "aacabcd";
            int[] next = new int[s2.Length];
            //int ret = MyIndexOf(s1, s2);
            GetNext(s2, next);

            foreach (var i in next)
            {
                Console.WriteLine(i);    
            }

            Console.ReadKey();
        }

        static int MyIndexOf(string s1, string s2)
        {
            int len1 = s1.Length;
            int len2 = s2.Length;

            int p;
            for (int i= 0;  i< len1 -len2; i++)
            {
                p = i;
                int j;
                for (j = 0; j < len2; j++)
                {
                    if (s1[p] == s2[j])
                    {
                        p++;
                    }
                    else
                    {
                        break;
                    }
                }
                if (j == len2)
                {
                    return i;
                }
            }

            return -1;
        }

        static void GetNext(string p, int[] next)
        {
            int i = 0;
            int j = -1;
            next[0] = -1;
            while (i < p.Length -1)
            {
                if (j == -1 || p[i] == p[j])
                {
                    i++;
                    j++;
                    next[i] = j;
                }
                else
                {
                    j = next[j];
                }                
            }
        }
    }
}
