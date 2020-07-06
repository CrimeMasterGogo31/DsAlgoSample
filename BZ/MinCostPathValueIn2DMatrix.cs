using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace DemoConsole.BeingZero.MinCostPathValueIn2DMatrix
{
    class MinCostPathValueIn2DMatrix
    {
        static int[,] mat;
        static int mincost;
        static int r, c;

        //public static void Main(string[] args)
        //{
        //    int t = ReadLineAsInt();
        //    while (t-- != 0)
        //    {
        //        mincost = int.MaxValue;
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
        //        MinPathSum(0, 0, 0);
        //        Console.WriteLine(mincost);
        //    }
        //}

        private static void MinPathSum(int x, int y, int sum)
        {
            if (x >= r || y >= c)
                return;
            
            sum += mat[x, y];

            if (x == r - 1 && y == c - 1)
            {

                if (mincost > sum)
                {
                    mincost = sum;
                }
                return;
            }

            MinPathSum(x, y + 1, sum);
            MinPathSum(x + 1, y + 1, sum);
            MinPathSum(x + 1, y, sum);
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
