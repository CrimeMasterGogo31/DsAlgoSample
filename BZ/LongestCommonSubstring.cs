using System;
using System.Collections.Generic;
using System.Text;

namespace DemoConsole.BZ
{
    class LongestCommonSubstring
    {
        string F; string S;
        int lcSubstringLen(string s, string t)
        {
            F = s;
            S = t;
            var res = lcSubstringLenDP(s.Length, t.Length, 0);
            return res;
        }

        int lcSubstringLenDP(int f, int s, int count)
        {
            if (f == 0 || s == 0)
                return count;

            if (F[f - 1] == S[s - 1])
            {
                count = lcSubstringLenDP(f - 1, s - 1, count + 1);
            }

            count = Math.Max(count, Math.Max(lcSubstringLenDP(f - 1, s, 0),
                lcSubstringLenDP(f, s - 1, 0)));
            return count;
        }
    }
}
