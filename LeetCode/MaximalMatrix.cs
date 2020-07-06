using System;
using System.Collections.Generic;
using System.Text;

namespace DemoConsole.LeetCode
{
    public class MaximalMatrix
    {
        public int MaximalSquare(char[][] mat)
        {
            int max = 0;
            if (mat == null)
                return 0;
            int r = mat.Length;
            int c = mat[0].Length;
            int[,] dp = new int[r, c];

            for (int i = r - 1, j = 0; j < c; j++)
            {
                if (mat[i][j] == 1)
                    dp[i, j] = 1;
            }

            for (int i = 0, j = c - 1; i < r; i++)
            {
                if (mat[i][j] == 1)
                    dp[i, j] = 1;
            }

            for (int i = r - 2; i >= 0; i--)
            {
                for (int j = c - 2; j >= 0; j--)
                {
                    if (mat[i][j] == 1)
                        dp[i, j] = 1 + Math.Max(dp[i + 1, j], Math.Max(dp[i + 1, j + 1], dp[i, j + 1]));

                    max = Math.Max(max, dp[i, j]);
                }
            }

            return max;
        }
    }
}
