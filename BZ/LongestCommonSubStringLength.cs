using System;
using System.Collections.Generic;
using System.Text;

namespace DemoConsole.BZ
{
    public class LongestCommonSubStringLength
    {
       public int lcSubstringLen(string s, string t)
        {
            int ans = 0;
            int slen = s.Length;
            int tlen = t.Length;
            int[,] m = new int[slen + 1, tlen + 1];
            for (int j = 0; j < tlen; j++)
            {
                if (s[0] == t[j])
                    m[0, j] = 1;
            }
            for (int i = 0; i < slen; i++)
            {
                if (s[i] == t[0])
                    m[i, 0] = 1;
            }

            for (int i = 1; i < slen; i++)
            {
                for (int j = 1; j < tlen; j++)
                {
                    if (s[i] == t[j])
                    {
                        m[i, j] = 1 + m[i - 1, j - 1];
                        if ((1 + m[i - 1, j - 1]) > ans)
                            ans = 1 + m[i - 1, j - 1];
                    }
                    else
                        m[i, j] = 0;
                }
            }

            return ans;

        }
    }
}
