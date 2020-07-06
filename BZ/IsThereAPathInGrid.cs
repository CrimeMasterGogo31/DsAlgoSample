using System;
using System.Collections.Generic;
using System.Text;

namespace DemoConsole.BZ
{
    class IsThereAPathInGridClass
    {
        static int row;
        static int col;
        static bool[,] dp;
        static int[,] mat;
        //public static void Main(string[] args)
        //{
        //    int t = Convert.ToInt32(Console.ReadLine());

        //    while (t-- != 0)
        //    {
        //        string line=string.Empty;
        //        while (string.IsNullOrEmpty(line)) {
        //            line = Console.ReadLine().Trim();
        //        }
        //        var input = Array.ConvertAll(line.Split(' '), wTemp => Convert.ToInt32(wTemp));
        //        row = input[0];
        //        col = input[1];
        //        dp = new bool[row, col];
        //        mat = new int[row, col];
        //        for (int i = 0; i < row; i++)
        //        {
        //            var rowArray = Array.ConvertAll(Console.ReadLine().Trim().Split(' '), wTemp => Convert.ToInt32(wTemp));
        //            for (int j = 0; j < col; j++)
        //            {
        //                mat[i, j] = rowArray[j];
        //            }
        //        }

        //        for (int i = 0; i < row; i++)
        //        {
        //            var rows = ReadLineAsIntArray();
        //            for (int j = 0; j < col; j++)
        //            {
        //                mat[i, j] = rows[j];
        //            }
        //        }

        //        IsThereAPathInGrid(row, col);
        //        Console.WriteLine(dp[row - 1, col - 1].ToString().ToLower());
        //    }
        //}
        static int[] ReadLineAsIntArray()
        {
            return Array.ConvertAll(Console.ReadLine().Trim().Split(' '), wTemp => Convert.ToInt32(wTemp));
        }

        private static void IsThereAPathInGrid(int row, int col)
        {
            for (int i = 0, j = 0; j < col; j++)
            {
                if (mat[i, j] == 0)
                {
                    dp[i, j] = true;
                }
                else
                {
                    break;
                }
            }
            for (int i = 1, j = 0; i < row; i++)
            {
                if (mat[i, j] == 0)
                {
                    dp[i, j] = true;
                }
                else
                {
                    break;
                }
            }

            for (int i = 1; i < row; i++)
            {
                for (int j = 1; j < col; j++)
                {
                    if (mat[i, j] == 0)
                    {
                        dp[i, j] = dp[i - 1, j] || dp[i, j - 1];
                    }
                }
            }
        }
    }
}
