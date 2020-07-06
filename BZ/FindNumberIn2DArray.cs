using System;
using System.Collections.Generic;
using System.Text;

namespace DemoConsole.BeingZero
{
    public class FindNumberIn2DArray
    {
        static int ReadInteger()
        {
            return Convert.ToInt32(Console.ReadLine());
        }
        static int[] ReadLineAsIntArray()
        {
            return Array.ConvertAll(Console.ReadLine().Trim().Split(' '), wTemp => Convert.ToInt32(wTemp));
        }

        //public static void Main(string[] args)
        //{
        //    int t = ReadInteger();
        //    while (t-- != 0)
        //    {
        //        var input = Console.ReadLine().Split(" ");
        //        var r = Convert.ToInt32(input[0]);
        //        var c = Convert.ToInt32(input[1]);
        //        var mat = new int[r, c];

        //        for (int i = 0; i < r; i++)
        //        {
        //            var rows = ReadLineAsIntArray();
        //            for (int j = 0; j < c; j++)
        //            {
        //                mat[i, j] = rows[j];
        //            }
        //        }

        //        findNumberInSortedGrid(mat, 7);
        //    }
        //}

        public static void findNumberInSortedGrid(int[,] mat, int k)
        {

            int r = mat.GetLength(0);
            int c = mat.GetLength(1);
            int i = 0;
            int j = c - 1;
            int resr = -1, resc = -1;

            while (i < r)
            {

                if (mat[i, j] == k)
                {
                    resr = i;
                    resc = j;
                    break;
                }
                if (mat[i, j] < k)
                {
                    i++;

                }
                else
                {
                    if (i != r)
                    {
                        while (j >= 0)
                        {
                            if (mat[i, j] == k)
                            {
                                resr = i;
                                resc = j;
                                break;
                            }
                            j--;
                        }
                    }
                    i++;
                    j = c - 1;
                }
            }

            if (resr == -1 || resc == -1)
            {
                Console.WriteLine(resr);
            }
            else
            {
                Console.WriteLine(resr + " " + resc);
            }
        }

        private static void PerformSerach(int[,] mat, int k, int r, int i, ref int j, ref int resr, ref int resc)
        {
            if (i != r)
            {
                while (j >= 0)
                {
                    if (mat[i, j] == k)
                    {
                        resr = i;
                        resc = j;
                        break;
                    }
                    j--;
                }
            }
        }
    }
}
