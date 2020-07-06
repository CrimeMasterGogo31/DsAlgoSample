using System;
using System.Collections.Generic;
using System.Text;

namespace DemoConsole.LeetCode
{
    public class SubArraySumEqualK
    {
        public int SubarraySum(int[] nums, int k)
        {
            Dictionary<int, int> dict = new Dictionary<int, int>();
            dict.Add(0, 1);
            int count = 0;
            int sum = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                sum += nums[i];
                if (dict.ContainsKey(sum - k))
                {
                    count += dict[sum - k];
                }

                if (dict.ContainsKey(sum))
                {
                    dict[sum]++;
                }
                else
                {
                    dict.Add(sum, 1);
                }
            }
            return count;

        }
    }
}
