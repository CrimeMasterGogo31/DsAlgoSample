using System;
using System.Collections.Generic;
using System.Text;

namespace DemoConsole
{
    public class TwoSumClass
    {
        public int[] TwoSum(int[] nums, int target)
        {
            var dict = new Dictionary<int, int>();
            var res = new int[2] { 0, 0 };
            for (int i = 0; i < nums.Length; i++)
                if (!dict.ContainsKey(nums[i]))
                {
                    if(!dict.ContainsKey(target - nums[i]))
                    dict.Add(target - nums[i], i);
                }
                else
                {
                    res = new int[2] { dict[nums[i]], i };
                    break;
                }
            return res;
        }
    }
}
