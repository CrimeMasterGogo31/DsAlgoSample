using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace DemoConsole.BeingZero.MaximumPathSumwithHurdles
{
    class BeingZero
    {
        static int[,] mat;
        static int maxcost;
        static int r, c;

        //public static void Main(string[] args)
        //{
        //    int t = ReadLineAsInt();
        //    while (t-- != 0)
        //    {
        //        maxcost = 0;
        //        int[] rnc = ReadLineAsIntArray();
        //        r = rnc[0];
        //        c = rnc[1];
        //        mat = new int[r, c];

        //        for (int i = 0; i < r; i++)
        //        {
        //            var rows = ReadLineAsIntArray();
        //            for (int j = 0; j < c; j++)
        //            {
        //                mat[i, j] = rows[j];
        //            }
        //        }
        //        MaximumPathSumwithHurdles(0, 0, 0);
        //        Console.WriteLine(maxcost);
        //    }
        //}

        private static void MaximumPathSumwithHurdles(int X, int Y, int cost)
        {
            if (X >= r || Y >= c)
                return;

            if (mat[X, Y] < 0)
                return;
            cost += mat[X, Y];
            if (X == r - 1 && Y == c - 1)
            {

                if (maxcost < cost)
                {
                    maxcost = cost;
                }
                return;
            }

            MaximumPathSumwithHurdles(X, Y + 1, cost);
            MaximumPathSumwithHurdles(X + 1, Y + 1, cost);
            MaximumPathSumwithHurdles(X + 1, Y, cost);
            return;
        }

        static int ReadLineAsInt()
        {
            return Convert.ToInt32(Console.ReadLine().Trim());
        }

        static int[] ReadLineAsIntArray()
        {
            return Array.ConvertAll(Console.ReadLine().Trim().Split(' '), wTemp => Convert.ToInt32(wTemp));
        }

        static List<int> ReadLineAsIntList()
        {
            int[] a = ReadLineAsIntArray();
            return a.OfType<int>().ToList();
        }
    }


}
