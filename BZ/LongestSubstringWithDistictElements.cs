using System;
using System.Collections.Generic;
using System.Text;

namespace DemoConsole.BZ
{
    class LongestSubstringWithDistictElements
    {
        //public static void Main(string[] args)
        //{
        //    int n = Convert.ToInt32(Console.ReadLine());
        //    while (n-- != 0)
        //    {
        //        string s = Console.ReadLine();
        //        PrintDistinctCharacters(s);

        //    }
        //}
        private static void PrintDistinctCharacters(string s)
        {
            HashSet<int> hash = new HashSet<int>(); //aabcdea
            char[] str = s.ToCharArray();
            int start = 0, len = 0;
            for (int e=0; e < s.Length;)
            {
                if (hash.Contains(str[e]))
                {
                    hash.Remove(str[start]);
                    start++;
                }
                else {
                    hash.Add(str[e]);
                    len = Math.Max(len, e - start + 1);
                    e++;
                }
            }
            Console.WriteLine(len);

        }
    }
}
