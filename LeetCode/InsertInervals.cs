using System;
using System.Collections.Generic;
using System.Text;

namespace DemoConsole.LeetCode
{
    public class InsertInervals
    {
        public int[][] Insert(int[][] intervals, int[] newInterval)
        {
            var result = new List<int[]>();
            if (intervals == null || intervals.Length == 0)
            {
                return result.ToArray();
            }
            int counter = 0;
            for (int i = 0; i < intervals.Length; i++)
            {
                if (newInterval[0] >= intervals[i][0])
                {
                    var start = intervals[i][0];
                    var end = 0;
                    counter = i;
                    while (intervals[counter][0] <= newInterval[1])
                    {
                        end = Math.Max(intervals[counter][1], newInterval[1]);
                    }
                    result.Add(new int[2] { start, end });
                    break;
                }
                else
                {
                    result.Add(intervals[i]);
                }
            }

            while (counter < intervals.Length)
            {
                result.Add(intervals[counter++]);
            }
            return result.ToArray();
        }
    }
}
