using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DemoConsole.BZ
{
    class MinCostClimbingStairs
    {
        static int[] dp;
        //public static void Main(string[] args)
        //{
        //    int t = ReadLineAsInt();
        //    while (t-- != 0)
        //    {
        //        int[] input = ReadLineAsIntArray();
        //        int len = input[0];
        //        input = input.Skip(1).ToArray();
        //        dp = new int[len];
        //        Console.WriteLine(FindMinCost(input, len));
        //    }
        //}
        static int[] ReadLineAsIntArray()
        {
            return Array.ConvertAll(Console.ReadLine().Trim().Split(' '), wTemp => Convert.ToInt32(wTemp));
        }
        static int ReadLineAsInt()
        {
            return Convert.ToInt32(Console.ReadLine().Trim());
        }
        public static int FindMinCost(int[] input, int len)
        {

            if (len == 1)
            {
                return input[0];
            }

            dp[0] = input[0];
            dp[1] = input[1];
            for (int i = 2; i < len; i++)
            {
                dp[i] = Math.Min(dp[i - 1],
                         dp[i - 2]) + input[i];
            }
            return Math.Min(dp[len - 2], dp[len - 1]);
        }
    }
}
