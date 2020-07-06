using System;
using System.Collections.Generic;
using System.Text;

namespace DemoConsole.LeetCode
{
    public class SolutionK
    {
        public int MinSetSize(int[] arr)
        {
            int t = (arr.Length + 1) / 2;
            Dictionary<int, int> d = new Dictionary<int, int>();
            foreach (int n in arr)
            {
                if (d.ContainsKey(n))
                    d[n]++;
                else
                    d.Add(n, 1);

            }
            List<int> values = new List<int>();
            foreach (var val in d.Values)
                values.Add(val);
            var valueArr = values.ToArray();
            var res = HasSum(valueArr,valueArr.Length, t);

            return res;
        }

        public int HasSum(int[] values, int n, int sum)
        {
            if (n <= 0)
                return 0;
            if (sum < 0)
                return 0;
            if (values[n - 1] == sum)
                return 1;

            if (values[n - 1] < sum)
            {
                return Math.Min(1 + HasSum(values, n - 1, sum - values[n - 1]),
                                     HasSum(values, n - 1, sum));
            }
            else
            {
                return HasSum(values, n - 1, sum);
            }

        }

    }
}
