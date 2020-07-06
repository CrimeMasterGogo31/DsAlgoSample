using System;
using System.Collections.Generic;
using System.Text;

namespace DemoConsole.LeetCode
{
    public class MinMeetingRoomsClass
    {
        public int MinMeetingRooms(int[][] intervals)
        {

            Array.Sort(intervals, (x, y) => Compare(x, y));
            var et = new List<int>();
            int count = 0;
            foreach (var i in intervals)
            {
                if (et.Count == 0)
                {
                    et.Add(i[1]);

                }
                else
                {
                    var ind = LowestIndexinArray(et, i[0]);
                    if (ind >= 0)
                    {
                        et[ind] = i[1];
                    }
                    else
                    {
                        et.Add(i[1]);
                    }
                }
                //Array.Sort(et.ToArray());
                count = Math.Max(count, et.Count);

            }
            return count;

        }

        private int LowestIndexinArray(List<int> et, int start)
        {
            int min = int.MaxValue;
            int minInd = 0;
            int ind = 0;
            foreach (var i in et)
            {
                if (min > i)
                {
                    min = i;
                    minInd = ind;
                }
                ind++;
            }

            if (min <= start)
                return minInd;
            else
                return -1;
        }

        private int Compare(int[] x, int[] y)
        {
            if (x[0] == y[0])
                return x[1] - y[1];
            return x[0] - y[0];
        }
    }
}
