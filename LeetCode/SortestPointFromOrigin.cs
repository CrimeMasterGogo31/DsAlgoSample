using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DemoConsole.LeetCode
{
    public class SortestPointFromOrigin
    {
        public int[][] KClosest(int[][] points, int K)
        {
            var list = new SortedList<double, List<int[]>>();

            foreach (var point in points)
            {
                var dis = Math.Sqrt((point[0] * point[0]) + (point[1] * point[1]));
                if (list.ContainsKey(dis))
                    list[dis].Add(point);
                else
                    list.Add(dis,
                        new List<int[]>()
                        {
                            point
                        });
            }

            var res = new List<int[]>() { };
            foreach (var arr in list)
            {
                if (K <= 0)
                    break;
                if (K >= arr.Value.Count)
                    res.AddRange(arr.Value);
                else
                    res.AddRange(arr.Value.Take(K));
                K -= arr.Value.Count;
            }
            return res.ToArray();
        }
    }
}
