using System;
using System.Collections.Generic;
using System.Text;

namespace DemoConsole.LeetCode
{
    public class FractionToDecimalClass
    {
        public string FractionToDecimal(int n, int d)
        {
            var res = "";

            res += (n / d).ToString();
            var rem = n % d;
            if (rem == 0)
                return res;

            rem *= 10;
            res += ".";
            var r = 0;
            var dec = "";
            var set = new HashSet<int>();
            set.Add(rem);
            while (rem != 0)
            {
                r = rem / d;
                if (rem % d == 0)
                {
                    dec += r.ToString();
                    break;
                }
                if (r == 0)
                {
                    rem *= 10;
                    dec += "0";
                    continue;
                }

                dec += r.ToString();
                rem = rem % d;
                rem *= 10;
                if (set.Contains(rem))
                {
                    dec = "(" + dec + ")";
                    break;
                }
                set.Add(rem);
            }
            res += dec;

            return res;
        }
    }
}
