using System;
using System.Collections.Generic;
using System.Text;

namespace DemoConsole.LeetCode
{
    public class RottingOrangeclass
    {
        public int OrangesRotting(int[][] grid)
        {
            var rottenList = new HashSet<string>();
            var nextDay = new Queue<string>();
            var r = grid.Length;
            var c = grid[0].Length;
            for (int i = 0; i < r; i++)
            {
                for (int j = 0; j < c; j++)
                {
                    if (grid[i][j] == 2)
                    {
                        string key = i + "#" + j;
                        nextDay.Enqueue(key);
                    }
                }
            }
            var days = 0;
            nextDay.Enqueue("day");
            while (nextDay.Count > 0)
            {

                var cur = nextDay.Dequeue();
                if (cur == "day")
                {
                    days++;

                    if (nextDay.Count > 0)
                        nextDay.Enqueue("day");
                }
                else
                {
                    BFS(cur, nextDay, rottenList, r, c, grid);
                }
            }

            for (int i = 0; i < r; i++)
            {
                for (int j = 0; j < c; j++)
                {
                    if (grid[i][j] == 1)
                    {
                        return -1;
                    }
                }
            }

            return days==0? 0:--days;

        }

        void BFS(string key, Queue<string> nextDay, HashSet<string> rottenList, int row, int col, int[][] grid)
        {
            var r = Convert.ToInt32(key.Split('#')[0]);
            var c = Convert.ToInt32(key.Split('#')[1]);

            //if (r < 0 || r >= row || c < 0 || c >= col)
            //    return;

            rottenList.Add(key);
            grid[r][c] = 2;

            key = $"{r + 1}#{c}";
            if (r + 1 < row && grid[r + 1][c] == 1 && !rottenList.Contains(key))
            {
                nextDay.Enqueue(key);
                rottenList.Add(key);
            }

            key = $"{r - 1}#{c}";
            if (r - 1 > 0 && grid[r - 1][c] == 1 && !rottenList.Contains(key))
            {
                nextDay.Enqueue(key);
                rottenList.Add(key);
            }

            key = $"{r}#{c + 1}";
            if (c + 1 < col && grid[r][c + 1] == 1 && !rottenList.Contains(key))
            {
                nextDay.Enqueue(key);
                rottenList.Add(key);
            }

            key = $"{r}#{c - 1}";
            if (c - 1 > 0 && grid[r][c - 1] == 1 && !rottenList.Contains(key))
            {
                nextDay.Enqueue(key);
                rottenList.Add(key);
            }

        }
    }
}
