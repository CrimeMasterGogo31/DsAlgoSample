using System;
using System.Collections.Generic;
using System.Text;

namespace DemoConsole.LeetCode
{
    public class RemoveKDigitClass
    {
        public string RemoveKdigits(string num, int k)
        {
            if (k == num.Length) { return "0"; }

            var sb = new StringBuilder();
            int c = 0;

            int i = 0, j = -1;

            while (i < num.Length)
            {
                if (j >= 0 && sb[j] > num[i] && c < k)
                {
                    c++; sb.Length--; j--;
                }
                else if (num[i] != '0' || sb.Length != 0)
                {
                    sb.Append(num[i]);
                    j++;
                    i++;
                }
                else { i++; }
            }


            if (c < k)
            {
                sb.Length -= k - c;
            }

            return (sb.Length == 0) ? "0" : sb.ToString();
        }
    }
}
