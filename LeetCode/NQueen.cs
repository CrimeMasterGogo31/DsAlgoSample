using System;
using System.Collections.Generic;
using System.Text;

namespace DemoConsole.LeetCode
{
    public class NQueen
    {
        IList<IList<string>> res = new List<IList<string>>();
        public IList<IList<string>> SolveNQueens(int n)
        {
            if (n == 0)
                return null;

            var b = new int[n, n];

            Visitcol(0, 0, b, n);
            return res;
        }

        void Visitcol(int r, int c, int[,] b, int n)
        {
            for (int j = c, i = 0; j < n && i < n; i++)
            {
                if (IsValidMove(i, j, b, n))
                {
                    b[i, j] = 1;
                    if ((j == n - 1))
                    {
                        PrintBoard(b, n);
                    }
                    else
                    {
                        Visitcol(0, c + 1, b, n);
                    }
                    b[i, j] = 0;
                }
            }
        }

        void PrintBoard(int[,] b, int n)
        {
            var r = new List<string>();
            for (int i = 0; i < n; i++)
            {
                var s = string.Empty;
                for (int j = 0; j < n; j++)
                {
                    if (b[i, j] == 1)
                        s += "Q";
                    else
                        s += ".";
                }
                r.Add(s);
            }
            this.res.Add(r);
        }

        bool IsValidMove(int r, int c, int[,] b, int n)
        {
            for (int i = r, j = 0; j < n; j++)
            {
                if (b[i, j] == 1)
                {
                    return false;
                }
            }

            for (int i = 0, j = c; i < n; i++)
            {
                if (b[i, j] == 1)
                {
                    return false;
                }
            }

            //down right
            for (int i = r, j = c; j < n && i < n; i++, j++)
            {
                if (b[i, j] == 1)
                {
                    return false;
                }
            }

            // up right
            for (int i = r, j = c; j < n && i >= 0; i--, j++)
            {
                if (b[i, j] == 1)
                {
                    return false;
                }
            }

            // top left
            for (int i = r, j = c; j >= 0 && i >= 0; i--, j--)
            {
                if (b[i, j] == 1)
                {
                    return false;
                }
            }

            // down left
            for (int i = r, j = c; j >= 0 && i < n; i++, j--)
            {
                if (b[i, j] == 1)
                {
                    return false;
                }
            }

            return true;
        }
    }
}
