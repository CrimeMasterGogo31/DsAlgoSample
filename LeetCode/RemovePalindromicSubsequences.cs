using System;
using System.Collections.Generic;
using System.Text;

namespace DemoConsole.LeetCode
{
    public class SolutionPalindrom
    {
        public int RemovePalindromeSub(string s)
        {
            if (string.IsNullOrEmpty(s))
                return 0;
            if (IsPalindrom(s))
                return 1;
            else
                return 2;
        }

        public bool IsPalindrom(string w)
        {
            int s = 0;
            int e = w.Length - 1;

            while (s < e)
            {
                if (w[s] != w[e])
                    return false;
                s++; e--;
            }
            return true;
        }
    }
}
