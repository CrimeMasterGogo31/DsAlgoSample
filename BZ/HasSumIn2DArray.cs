using System;
using System.Collections.Generic;
using System.Text;

namespace DemoConsole.BZ
{
    class HasSumIn2DArray
    {
        static int R, C;

        static List<List<int>> matd;

        static bool hasSum(List<List<int>> mat, int sum)
        {
            R = mat.Count;
            C = mat[0].Count;
            matd = mat;
            return hasSumRecursive(0, 0, sum);
        }

        static bool hasSumRecursive(int i, int j, int sum)
        {
            if (i >= R || j >= C)
            {
                return false;
            }
            if (sum == 0 && (i <= R - 1 || j <= C - 1))
            {
                return false;
            }
            if (sum < 0)
            {
                return false;
            }
            if (i == R - 1 && j == C - 1)
            {
                if (matd[R - 1][C - 1] == sum)
                    return true;
            }
            return hasSumRecursive(i + 1, j, sum - matd[i][j]) || hasSumRecursive(i, j + 1, sum - matd[i][j]);
        }
        //static void Main(String[] args)
        //{
        //    int t = Convert.ToInt32(Console.ReadLine());
        //    while (t-- != 0)
        //    {
        //        string[] rcString = Console.ReadLine().Split(' ');
        //        int[] rcArr = Array.ConvertAll(rcString, Int32.Parse);
        //        int r = rcArr[0];
        //        int c = rcArr[1];
        //        List<List<int>> matrix = new List<List<int>>();
        //        for (int ri = 0; ri < r; ri++)
        //        {
        //            string[] colStr = Console.ReadLine().Split(' ');
        //            int[] colArr = Array.ConvertAll(colStr, Int32.Parse);
        //            List<int> colList = new List<int>(colArr);
        //            matrix.Add(colList);
        //        }
        //        string queriesCount = Console.ReadLine();
        //        string[] queriesStrings = Console.ReadLine().Split(' ');
        //        int[] sums = Array.ConvertAll(queriesStrings, Int32.Parse);
        //        foreach (int sum in sums)
        //        {
        //            if (hasSum(matrix, sum))
        //                Console.Write("true ");
        //            else
        //                Console.Write("false ");
        //        }
        //        Console.WriteLine();
        //    }
        //}
    }
}
