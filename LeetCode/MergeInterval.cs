using System;
using System.Collections.Generic;
using System.Text;

namespace DemoConsole.LeetCode
{
   public class MergeInterval
    {
        public int[][] Merge(int[][] intervals)
        {
            if (intervals == null)
            {
                return new int[0][];
            }
            var cmp = new CompareInt();
            Array.Sort(intervals, cmp);
            var res = new List<int[]>();
            int curstart = intervals[0][0];
            int curend = intervals[0][1];

            foreach (var interval in intervals)
            {
                if (interval[0] <= curend)
                {
                    curend = Math.Max(interval[1], curend);
                }
                else
                {
                    res.Add(new int[2] { curstart, curend });
                }
            }

            res.Add(new int[2] { curstart, curend });
            return res.ToArray();
        }
    }

    public class CompareInt : IComparer<int[]>
    {
        public int Compare(int[] x, int[] y)
        {
            if (x[0] == y[0])
                return x[1] - y[1];
            else
                return x[0] - y[0];

        }
    }
}
