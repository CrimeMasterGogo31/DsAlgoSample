using System;
using System.Collections.Generic;
using System.Text;

namespace DemoConsole.BeingZero.dup
{
    class SubsetSumWithNoConsicutive
    {
        static bool[,] dp = new bool[1001, 1001];
        public static int[] intput;
        //public static void Main(string[] args)
        //{

        //    int t = Convert.ToInt32(Console.ReadLine());

        //    for (int i = 0; i < t; i++)
        //    {
        //        int n = Convert.ToInt32(Console.ReadLine());
        //        intput = ReadLineAsIntArray();
        //        int query = Convert.ToInt32(Console.ReadLine());
        //        int[] sums = ReadLineAsIntArray();
        //        foreach (var s in sums)
        //        {
        //            ComputeDPBottomUp(n, s, intput);
        //            Console.Write(dp[n, s].ToString().ToLower() + " ");
        //        }
        //    }
        //    Console.WriteLine();

        //}

        public static void ComputeDPBottomUp(int n, int s, int[] input)
        {
            for (int i = 0, j = 0; i < n + 1; i++)
            {
                dp[i, j] = true;
            }

            for (int i = 0, j = 1; j < s + 1; j++)
            {
                dp[i, j] = false;
            }

            for (int i = 1, j = 1; j < s + 1; j++)
            {
                if (input[0] == j)
                {
                    dp[i, j] = true;
                    continue;
                }
                dp[i, j] = false;
            }

            for (int i = 2; i <= n; i++)
            {
                for (int j = 1; j <= s; j++)
                {
                    dp[i, j] = false;
                    if (j >= input[i - 1] && (i - 2) >= 0)
                    {
                        dp[i, j] = dp[i, j] || dp[i - 2, j - input[i - 1]];
                    }
                    dp[i, j] = dp[i, j] || dp[i - 1, j];
                }
            }
        }

        static int[] ReadLineAsIntArray()
        {
            return Array.ConvertAll(Console.ReadLine().Trim().Split(' '), wTemp => Convert.ToInt32(wTemp));
        }
    }
}
