using System;
using System.Collections.Generic;
using System.Text;

namespace DemoConsole.LeetCode
{
    public class Solution
    {
        public int[] KWeakestRows(int[][] mat, int k)
        {
            List<Count> list = new List<Count>();
            int r = 0;
            foreach (var row in mat)
            {
                int count = 0;
                foreach (int i in row)
                {
                    if (i == 1)
                    {
                        count++;
                    }
                }
                list.Add(new Count(r++, count));
            }

            var CompareRows = new CompareRows();
            var arrList = list.ToArray();
            Array.Sort(arrList, CompareRows);
            var res = new int[k];
            for (int c = 0; c < k; c++)
            {
                res[c] = arrList[c].row;
            }
            return res;
        }

    }
    public class Count
    {
        public int row;
        public int sol;

        public Count(int r, int s)
        {
            row = r;
            sol = s;
        }
    }

    public class CompareRows : IComparer<Count>
    {

        public int Compare(Count x, Count y)
        {
            if (x.sol == y.sol)
               return x.row - y.row;
            else
             return x.sol - y.sol;
        }
    }
}
