using System;
using System.Collections.Generic;
using System.Text;

namespace DemoConsole.BeingZero
{
    class BinomialCoeeficient
    {
        static int[,] dp;
        static int modSum(long a, long b)
        {
            int M = (int)1e9 + 7;
            return (int)((a % M + b % M) % M);
        }
        //public static void Main(string[] args)
        //{
        //    int num = Convert.ToInt32(Console.ReadLine());
        //    while (num-- != 0)
        //    {
        //        var input = Console.ReadLine();
        //        var input_arrayPlace = input.Split(' ');
        //        int n = Convert.ToInt32(input_arrayPlace[0]);
        //        int r = Convert.ToInt32(input_arrayPlace[1]);
        //        dp = new int[n + 1, r + 1];

        //        for (int i = 0; i < n + 1; i++)
        //        {
        //            for (int j = 0; j < r + 1; j++)
        //            {
        //                dp[i, j] = -1;
        //            }
        //        }
        //        Console.WriteLine(Bc(n, r));
        //    }
        //}

        static int Bc(int n, int r)
        {
            if (r == 0 || r == n)
                return 1;

            if (dp[n, r] != -1)
            {
                return dp[n, r];
            }

            return dp[n, r] = modSum((Bc(n - 1, r)), Bc(n - 1, r - 1));

        }
    }
}