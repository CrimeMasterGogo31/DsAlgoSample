using System;
using System.Collections.Generic;
using System.Text;

namespace DemoConsole.LeetCode
{
    public class MineSweeper
    {
        public char[][] UpdateBoard(char[][] board, int[] click)
        {
            if (board[click[0]][click[1]] == 'M')
            {
                board[click[0]][click[1]] = 'X';
                return board;
            }

            Expand(board, click);
            return board;
        }

        void Expand(char[][] board, int[] click)
        {
            var q = new Queue<int[]>();
            var set = new HashSet<string>();
            q.Enqueue(click);
            set.Add($"{click[0]},{click[1]}");

            while (q.Count > 0)
            {
                var cur = q.Dequeue();
                var count = GetCount(board, cur[0], cur[1]);
                if (count == 0)
                {
                    board[cur[0]][cur[1]] = 'B';
                    AddAdjacentToqueue(board, cur[0], cur[1], q, set);
                }
                else
                    board[cur[0]][cur[1]] = Convert.ToChar(count.ToString());
            }
        }

        void AddAdjacentToqueue(char[][] board, int x, int y, Queue<int[]> q, HashSet<string> set)
        {
            var key = $"{ x - 1 },{y }";
            if (x - 1 >= 0 && !set.Contains(key))
            {
                q.Enqueue(new int[2] { x - 1, y });
                set.Add(key);
            }
            key = $"{x - 1 },{y + 1 }";
            if (x - 1 >= 0 && y + 1 < board[0].Length && !set.Contains(key))
            {
                q.Enqueue(new int[2] { x - 1, y + 1 });
                set.Add(key);
            }
            key = $"{x },{ y + 1}";
            if (y + 1 < board[0].Length && !set.Contains(key))
            {
                q.Enqueue(new int[2] { x, y + 1 });
                set.Add(key);
            }
            key = $"{ x + 1},{ y + 1}";
            if (x + 1 < board.Length && y + 1 < board[0].Length && !set.Contains(key))
            {
                q.Enqueue(new int[2] { x + 1, y + 1 });
                set.Add(key);
            }
            key = $"{ x + 1},{ y}";
            if (x + 1 < board.Length && !set.Contains(key))
            {
                q.Enqueue(new int[2] { x + 1, y });
                set.Add(key);
            }
            key = $"{x + 1 },{ y - 1}";
            if (x + 1 < board.Length && y - 1 >= 0 && !set.Contains(key))
            {
                q.Enqueue(new int[2] { x + 1, y - 1 });
                set.Add(key);
            }
            key = $"{ x},{ y - 1}";
            if (y - 1 >= 0 && !set.Contains(key))
            {
                q.Enqueue(new int[2] { x, y - 1 });
                set.Add(key);
            }
            key = $"{x - 1 },{ y - 1}";
            if (x - 1 >= 0 && y - 1 >= 0 && !set.Contains(key))
            {
                q.Enqueue(new int[2] { x - 1, y - 1 });
                set.Add(key);
            }
        }

        int GetCount(char[][] board, int x, int y)
        {
            var total = 0;

            if (x - 1 >= 0 && board[x - 1][y] == 'M')
                total++;
            if (x - 1 >= 0 && y + 1 < board[0].Length && board[x - 1][y + 1] == 'M')
                total++;
            if (y + 1 < board[0].Length && board[x][y + 1] == 'M')
                total++;
            if (x + 1 < board.Length && y + 1 < board[0].Length && board[x + 1][y + 1] == 'M')
                total++;
            if (x + 1 < board.Length && board[x + 1][y] == 'M')
                total++;
            if (x + 1 < board.Length && y - 1 >= 0 && board[x + 1][y - 1] == 'M')
                total++;
            if (y - 1 >= 0 && board[x][y - 1] == 'M')
                total++;
            if (x - 1 >= 0 && y - 1 >= 0 && board[x - 1][y - 1] == 'M')
                total++;

            return total;
        }
    }
}
