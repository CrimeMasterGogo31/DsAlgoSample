using System;
using System.Collections.Generic;
using System.Text;

namespace DemoConsole.LeetCode
{
    class MaximumEvents
    {
        public int MaxEvents(int[][] events)
        {
            int[] mergedInt = new int[2];
            int totalEvent = 0;
            var cmp = new compareClass();
            Array.Sort(events, cmp);

            foreach (var e in events)
            {
                if (e[0] >= mergedInt[0] && e[1] <= mergedInt[1])
                    continue;
                else
                {
                    int temp = e[0];
                    while (temp <= e[1])
                    {
                        if (mergedInt[1] < temp)
                        {
                            mergedInt[1] = temp;
                            if (mergedInt[0] == 0)
                                mergedInt[0] = temp;
                            totalEvent++;
                            break;
                        }
                        if (temp < mergedInt[0])
                        {
                            mergedInt[0] = temp;
                            totalEvent++;
                            break;
                        }
                        temp++;
                    }
                }
            }
            return totalEvent;
        }

        public class compareClass : IComparer<int[]>
        {

            public int Compare(int[] x, int[] y)
            {
                if (x[1] == y[1])
                    return x[0] - y[0];
                return x[1] - y[1];
            }
        }
    }
}
