﻿using System;
using System.Collections.Generic;
using System.Text;

namespace DemoConsole.LeetCode
{
    // Dynamic Programing
    // Bottom Up
    // TC O(M*N)
    // SP O(M*N)
    public class UniquePathInMatrix
    {
        public int UniquePaths(int m, int n)
        {
            var dp = new int[m, n];

            for (int i = 0; i < m; i++)
                dp[i, 0] = 1;

            for (int j = 0; j < n; j++)
                dp[0, j] = 1;

            for (int i = 1; i < m; i++)
            {
                for (int j = 1; j < n; j++)
                    dp[i, j] = dp[i - 1, j] + dp[i, j - 1];
            }

            return dp[m - 1, n - 1];
        }
    }
}
