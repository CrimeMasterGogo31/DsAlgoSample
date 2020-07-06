using System;
using System.Collections.Generic;
using System.Text;

namespace DemoConsole.InterviewBits
{
    class MaxConsicutive1s
    {
        public List<int> maxone(List<int> A, int B)
        {
            int s = 0, e = 0;
            var maxInterval = 0;
            var interval = 0;
            var intervalList = new int[2];
            int zeroinCurrentRange = 0; ;
            while (s <= e && e < A.Count)
            {
                if (A[e] == 1)
                {
                    e++;
                    continue;
                }
                else if (zeroinCurrentRange < B)
                {
                    zeroinCurrentRange++;
                    e++;
                }
                else
                {
                    interval = e - s;
                    if (interval > maxInterval)
                    {
                        maxInterval = interval;
                        intervalList[0] = s;
                        intervalList[1] = e - 1;
                    }
                    while (zeroinCurrentRange == B)
                    {
                        if (A[s] != 0)
                        {
                            s++;

                        }
                        {
                            zeroinCurrentRange--;
                        }
                    }
                    if (s == e)
                    {
                        e++;
                        s++;

                    }
                    else {
                        s++;
                    }
                }
            }
            interval = e - s;
            if (interval > maxInterval)
            {
                maxInterval = interval;
                intervalList[0] = s;
                intervalList[1] = e - 1;
            }
            var res = new List<int>();

            if (maxInterval == 0)
                return null;
            else
            {
                for (int i = intervalList[0]; i <= intervalList[1]; i++)
                {
                    res.Add(i);
                }
            }
            return res;
        }
    }
}
