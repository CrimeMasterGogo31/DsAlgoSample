using System;
using System.Collections.Generic;
using System.Text;

namespace DemoConsole.LeetCode
{
    public class LongestHappyString
    {
        string res = "";
        int max = int.MinValue;
        public string LongestDiverseString(int a, int b, int c)
        {
            findhappy(a, b, c, "");
            return res;
        }

        void findhappy(int a, int b, int c, string str)
        {
            if (str.Contains("aaa") || str.Contains("bbb") || str.Contains("ccc"))
                return;
            if (a <= 0 && b <= 0 & c <= 0)
                return;
            if (str.Length > max)
            {
                res = str;
                max = str.Length;
            }

            if (a > 0)
            {
                findhappy(a - 1, b, c, str + "a");
            }
            if (b > 0)
            {
                findhappy(a, b - 1, c, str + "b");
            }

            if (c > 0)
            {
                findhappy(a, b, c - 1, str + "c");
            }
                
            
        }
    }
}
