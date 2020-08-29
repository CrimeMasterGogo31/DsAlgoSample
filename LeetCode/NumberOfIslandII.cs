using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DemoConsole.LeetCode
{
    public class NumberOfIsland
    {
        public IList<int> NumIslands2(int m, int n, int[][] positions)
        {
            int count = 0;

            var mat = new int[m, n];
            var result = new List<int>();
            foreach (var pos in positions)
            {
                if (mat[pos[0], pos[1]] == 0)
                {
                    var set = connectedIsland(pos[0], pos[1], mat, m, n);
                    if (set.Count == 0)
                    {
                        count++;
                        mat[pos[0], pos[1]] = count;
                    }
                    else
                    {
                        mat[pos[0], pos[1]] = set.First();

                        FlodFill(pos[0] + 1, pos[1], mat, set.First(), m, n);
                        FlodFill(pos[0] - 1, pos[1], mat, set.First(), m, n);
                        FlodFill(pos[0], pos[1] + 1, mat, set.First(), m, n);
                        FlodFill(pos[0], pos[1] - 1, mat, set.First(), m, n);
                        count = count - (set.Count - 1);
                    }
                }
                result.Add(count);
            }
            return result;
        }

        void FlodFill(int i, int j, int[,] mat, int val, int r, int c)
        {
            if (i < 0 || i >= r || j < 0 || j >= c)
                return;
            if (mat[i, j] == 0 || mat[i, j] == val)
                return;

            mat[i, j] = val;

            FlodFill(i + 1, j, mat, val, r, c);
            FlodFill(i - 1, j, mat, val, r, c);
            FlodFill(i, j + 1, mat, val, r, c);
            FlodFill(i, j - 1, mat, val, r, c);
        }

        HashSet<int> connectedIsland(int m, int n, int[,] mat, int r, int c)
        {
            var set = new HashSet<int>();
            if (m + 1 < r && mat[m + 1, n] != 0)
                set.Add(mat[m + 1, n]);
            if (n + 1 < c && mat[m, n + 1] != 0)
                set.Add(mat[m, n + 1]);
            if (m - 1 >= 0 && mat[m - 1, n] != 0)
                set.Add(mat[m - 1, n]);
            if (n - 1 >= 0 && mat[m, n - 1] != 0)
                set.Add(mat[m, n - 1]);
            return set;
        }
    }
}
