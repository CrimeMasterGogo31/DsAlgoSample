using System;
using System.Collections.Generic;
using System.Text;

namespace DemoConsole.LeetCode
{
    public class SearchIn2DMatrix
    {
        public bool SearchMatrix(int[][] matrix, int target)
        {
            int start = 0;
            int r = matrix[0].Length-1;
            int end = matrix.Length - 1;

            while (start <= end)
            {
                if (start == end)
                {
                    return Binary(start, r, matrix, target);
                }
                var mid = start + ((end - start) / 2);
                if (matrix[mid][0] == target)
                    return true;
                if (matrix[mid][0] > target)
                {
                    end = mid - 1;
                }
                else
                {
                    if (matrix[mid][r] == target)
                        return true;
                    if (matrix[mid][r] < target)
                        start = mid + 1;
                    else
                        return Binary(mid, r, matrix, target);
                }
            }


            return false;
        }

        bool Binary(int row, int r, int[][] matrix, int t)
        {
            int[] arr = matrix[row];
            int l = 0;
            while (l <= r)
            {
                var mid = l + ((r - l) / 2);
                if (arr[mid] == t)
                    return true;
                if (arr[mid] < t)
                {
                    l = mid + 1;
                }
                else
                {
                    r = mid - 1;
                }
            }
            return false;
        }
    }
}
