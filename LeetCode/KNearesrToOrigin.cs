using System;
using System.Collections.Generic;
using System.Text;

namespace DemoConsole.LeetCode
{
    public class KNearesrToOrigin
    {
        public int[][] KClosest(int[][] points, int K)
        {
            var cmp = new comp();

            Array.Sort(points, cmp);

            var res = new int[K][];
            for (int i = 0; i < K; i++)
            {
                res[i] = points[i];
            }
            return res;
        }
    }

    public class comp : IComparer<int[]>
    {

        public int Compare(int[] x, int[] y)
        {
            var xval = Math.Abs((x[0] * x[0]) + (x[1] * x[1]));
            var yval = Math.Abs((y[0] * y[0]) + (y[1] * y[1]));
            if (xval == yval) //ascending order 
                return xval - yval;
            else
                return xval - yval;
        }
    }
}
