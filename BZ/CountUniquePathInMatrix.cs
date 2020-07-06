using System;
using System.Collections.Generic;
using System.Text;

namespace DemoConsole.BZ
{
    class CountUniquePathInMatrixClass
    {
        static int[,] mat;
        static int row;
        static int col;
        //public static void Main(string[] args)
        //{

        //    int t = Convert.ToInt32(Console.ReadLine());

        //    for (int i = 0; i < t; i++)
        //    {
        //        var input = Array.ConvertAll(Console.ReadLine().Trim().Split(' '), wTemp => Convert.ToInt32(wTemp));
        //        row = input[0];
        //        col = input[1];
        //        mat = new int[row, col];


        //        CountUniquePathInMatrix(row, col);
        //        Console.WriteLine(mat[0, col-1]);
        //    }

        //}

        private static void CountUniquePathInMatrix(int r, int c)
        {
            for (int i = 0, j = 0; i <= row - 1; i++)
                mat[i, j] = 1;
            for (int i = row-1, j = 0; j <= col - 1; j++)
                mat[i, j] = 1;

            for (int i = r - 2; i >= 0; i--)
            {
                for (int j = 1; j < c; j++)
                {
                    if (i >= 0 && j < col)
                        mat[i, j] = mat[i, j - 1] + mat[i + 1, j];
                }
            }

        }
    }
}
