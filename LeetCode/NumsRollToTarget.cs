using System;
using System.Collections.Generic;
using System.Text;

namespace DemoConsole.LeetCode
{
    public class NumsRollToTarget
    {
        int result;
        int prime = (int)1e9 + 7;
        public int NumRollsToTarget(int d, int f, int target)
        {
            result = 0;

            Compute(d, f, new List<int>(), 0, target);

            return result;
        }

        void Compute(int d, int f, List<int> list, int cur, int target)
        {


            if (cur == target)
            {
                if (list.Count == d)
                    result = ((result % prime) + 1) % prime;
                else
                    return;
            }

            if (cur > target || list.Count == d)
                return;

            for (int i = 1; i <= f; i++)
            {
                list.Add(i);
                Compute(d, f, list, cur + i, target);
                list.Remove(i);

            }
        }
    }
}
