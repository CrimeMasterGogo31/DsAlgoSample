using System;
using System.Collections.Generic;
using System.Text;

namespace DemoConsole.BZ
{
    public class MinimumEditDistance
    {
        char[] f;
        char[] s;
        int[,] mat;

        public int editDistance(char[] s1, char[] s2)
        {
            f = s1;
            s = s2;
            mat = new int[s1.Length + 1, s2.Length + 1];
            var res = editDistanceDPBU(s1.Length, s2.Length);
            return res;
        }

        public int editDistanceDP(int f_len, int s_len)
        {
            if (f_len <= 0)
                return s_len;
            if (s_len <= 0)
                return f_len;
            if (f[f_len - 1] == s[s_len - 1])
                return editDistanceDP(f_len - 1, s_len - 1);

            else
                return 1 + Math.Min(editDistanceDP(f_len, s_len - 1),
                                   Math.Min(editDistanceDP(f_len - 1, s_len - 1),
                                            editDistanceDP(f_len - 1, s_len)));
        }

        public int editDistanceDPBU(int f_len, int s_len)
        {

            for (int i = 0; i <= s_len; i++)
            {
                mat[0, i] = i;
            }
            for (int i = 0; i <= f_len; i++)
            {
                mat[i, 0] = i;
            }


            for (int i = 1; i <= f_len; i++)
            {
                for (int j = 1; j <= s_len; j++)
                {
                    if (f[i - 1] == s[j - 1])
                    {
                        mat[i, j] = mat[i - 1, j - 1];
                    }
                    else
                    {
                        mat[i, j] = 1 + Math.Min(mat[i, j - 1], Math.Min(mat[i - 1, j - 1], mat[i - 1, j]));
                    }
                }
            }
            return mat[f_len, s_len];
        }

    }
}
