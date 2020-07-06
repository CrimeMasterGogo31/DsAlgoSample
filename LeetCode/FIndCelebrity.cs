using System;
using System.Collections.Generic;
using System.Text;

namespace DemoConsole.LeetCode
{
    public class FIndCelebrity
    {
        public int TitleToNumber(string s)
        {
            s = s.ToLower();
            double res = 0;
            int c = 0;
            for (int i = s.Length; i >= 0; i--)
            {
                var ch = s[i];
                int val = ch - 'a';
                res += Math.Pow(26, c++) * val;
            }
            return (int)(res);
        }
    }
}
