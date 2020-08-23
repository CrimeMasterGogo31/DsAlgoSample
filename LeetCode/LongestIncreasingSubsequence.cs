using System;
using System.Collections.Generic;
using System.Text;

namespace DemoConsole.LeetCode
{
    public class LongestIncreasingSubsequence
    {
        public int LengthOfLIS(int[] nums)
        {
            if (nums == null || nums.Length == 0)
                return 0;
            if (nums.Length == 1)
                return 1;
            var max = 0;
            var dp = new int[nums.Length];
            dp[0] = 1;
            for (int i = 1; i < nums.Length; i++)
            {
                int localmax = 0;
                for (int j = 0; j < i; j++)
                {
                    if (nums[i] > nums[j])
                    {
                        localmax = Math.Max(dp[j] + 1, localmax);
                    }
                    else
                    {
                        localmax = Math.Max(localmax, 1);
                    }
                }
                dp[i] = localmax;
                max = Math.Max(max, localmax);
            }
            return max;
        }
    }
}
