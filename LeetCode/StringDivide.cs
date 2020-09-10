using System;
using System.Collections.Generic;
using System.Text;

namespace DemoConsole.LeetCode
{
    public class StringDivide
    {
        //        "TAUXXTAUXXTAUXXTAUXXTAUXX"
        //"TAUXXTAUXXTAUXXTAUXXTAUXXTAUXXTAUXXTAUXXTAUXX"

        public string GcdOfStrings(string str1, string str2)
        {
            if (str1.Length < str2.Length)
            {
                var t = str1;
                str1 = str2;
                str2 = t;
            }
            var ans = "";
            var max = 0;
            int i = str2.Length;
            while (i > 0)
            {
                if (str1.Length % i == 0 && str2.Length % i == 0  && divide(str1, str2, i))
                {
                    ans = str2.Substring(0, i);
                    max = i;
                    return ans;
                }
                else
                {
                    i--;
                }
            }
            return ans;
        }

        bool divide(string str1, string str2, int len)
        {
            var sub = str2.Substring(0, len);
            var t = 0;
            for (int i = 0; i < str2.Length; i++)
            {
                if (str2[i] != sub[t++])
                    return false;
                if (t == len)
                    t = 0;
            }
            t = 0;
            for (int i = 0; i < str1.Length; i++)
            {
                if (str1[i] != sub[t++])
                    return false;
                if (t == len)
                    t = 0;
            }

            return true;
        }
    }
}
