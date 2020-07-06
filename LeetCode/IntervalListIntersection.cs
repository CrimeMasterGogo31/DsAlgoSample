using System;
using System.Collections.Generic;
using System.Text;

namespace DemoConsole.LeetCode
{
    public class IntervalListIntersection
    {
        public int[][] IntervalIntersection(int[][] A, int[][] B)
        {
            int a = 0, b = 0;
            var result = new List<int[]>();
            while (a < A.Length && b < B.Length)
            {

                int start, end;
                var aint = A[a];
                var bint = B[b];

                if (bint[1] < aint[0])
                {
                    b++;
                    continue;
                }

                if (aint[1] < bint[0])
                {
                    a++;
                    continue;
                }


                if (aint[0] <= bint[0])
                {
                    start = bint[0];
                }
                else
                {
                    start = aint[0];
                }

                if (aint[1] == bint[1])
                {
                    end = aint[1];
                    a++;
                    b++;
                }
                else if (aint[1] < bint[1])
                {
                    end = aint[1];
                    a++;
                }
                else
                {
                    end = bint[1];
                    b++;
                }
                result.Add(new int[2] { start, end });
            }

            return result.ToArray();
        }
    }
}
