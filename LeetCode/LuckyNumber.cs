using System;
using System.Collections.Generic;
using System.Text;

namespace DemoConsole.LeetCode
{
    public class LuckyNumber
    {
        public IList<int> LuckyNumbers(int[][] matrix)
        {
            var rowMinList = new List<List<int>>();
            int rowMin = int.MaxValue;
            int minInd = 0;
            foreach (var r in matrix)
            {
                rowMin = int.MaxValue;
                minInd = 0;
                for (int i = 0; i < r.Length; i++)
                {
                    if (rowMin > r[i])
                    {
                        minInd = i;
                        rowMin = r[i];
                    }
                }
                rowMinList.Add(new List<int>() { rowMin, minInd });
            }

            var maxColList = new int[matrix[0].Length];
            int col = matrix[0].Length;
            int row = matrix.Length;
            int colMax = int.MinValue;
            for (int i = 0; i < col; i++)
            {
                colMax = int.MinValue;
                for (int j = 0; j < row; j++)
                {
                    colMax = Math.Max(colMax, matrix[j][i]);
                }
                maxColList[i] = colMax;

            }
            var ret = new List<int>();
            foreach (var colminpair in rowMinList)
            {
                if (maxColList[colminpair[1]] == colminpair[0])
                    ret.Add(colminpair[0]);
            }
            return ret;
        }
    }
}
