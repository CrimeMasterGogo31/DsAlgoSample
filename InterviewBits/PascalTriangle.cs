using System;
using System.Collections.Generic;
using System.Text;

namespace DemoConsole.InterviewBits
{
    public class PascalTriangle
    {
        public List<List<int>> solve(int A)
        {
            var res = new List<List<int>>();
            for (int i = 0; i < A; i++)
            {
                var row = new List<int>();
                for (int j = 0; j < i + 1; j++)
                {
                    row.Add(1);
                }
                res.Add(row);
            }

            for (int i = 0, j = 0; i < A && j < A; i++, j++)
            {
                res[i][0] = 1;
                res[i][j] = 1;
            }

            for (int i = 2; i < A; i++)
            {
                for (int j = 1; j < i ; j++)
                {
                    res[i][j] = res[i - 1][j] + res[i - 1][j - 1];
                }
            }

            return res;
        }
    }
}
