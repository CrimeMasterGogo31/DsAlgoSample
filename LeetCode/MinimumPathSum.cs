using System;
using System.Collections.Generic;
using System.Text;

namespace DemoConsole.LeetCode
{
    public class MinimumPathSum
    {
        int sum;
        public int MinPathSum(int[][] grid)
        {
            if (grid == null || grid.Length == 0)
                return 0;

            sum = int.MaxValue;
            calculate(0, 0, 0, grid);

            return sum;
        }

        void calculate(int x, int y, int cursum, int[][] grid)
        {
            int r = grid.Length;
            int c = grid[0].Length;
            if (x >= r || x < 0 || y >= c || y < 0)
                return;
            cursum += grid[x][y];

            if (x == r - 1 && y == c - 1)
            {
                sum = Math.Min(sum, cursum);
                return;
            }
            if (cursum > sum)
                return;
            calculate(x, y + 1, cursum, grid);
            calculate(x + 1, y, cursum, grid);
            return;

        }
    }
}
