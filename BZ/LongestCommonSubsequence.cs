using System;
using System.Collections.Generic;
using System.Text;

namespace DemoConsole.BZ
{
    class LongestCommonSubsequence
    {
        int lcsLen(char[] s1, char[] s2)
        {
            int[,] m = new int[s1.Length + 1, s2.Length + 1];

            for (int i = 0, j = 0; i <= s1.Length; i++)
            {
                m[i, j] = 0;
            }
            for (int i = 0, j = 0; j <= s2.Length; j++)
            {
                m[i, j] = 0;
            }

            for (int i = 1; i <= s1.Length; i++)
            {
                for (int j = 1; j <= s2.Length; j++)
                {
                    if (s1[i - 1] == s2[j - 1])
                        m[i, j] = 1 + m[i - 1, j - 1];
                    else
                        m[i, j] = Math.Max(m[i - 1, j], m[i, j - 1]);
                }
            }

            return m[s1.Length, s2.Length];

        }
    }
}
