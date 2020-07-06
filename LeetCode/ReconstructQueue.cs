using System;
using System.Collections.Generic;
using System.Text;

namespace DemoConsole.LeetCode
{
    public class ReconstructQueueClass
    {
        public int[][] ReconstructQueue(int[][] people)
        {
            Array.Sort(people, (x, y) => x[0] - y[0]);

            var res = new int[people.Length][];

            foreach (var p in people)
            {
                var counter= p[1];
                var index = 0;
                while (counter >= 0)
                {
                    if (res[index] == null || res[index][0] >= p[0])
                        counter--;
                    index++;

                }
                res[index] = p; 

                //if (res[p[1]] == null)
                //    res[p[1]] = p;
                //else
                //{
                //    var ind = p[1];
                //    while (res[++ind] != null)

                //        res[ind] = p;
                //}
            }

            return res;
        }
    }
}
