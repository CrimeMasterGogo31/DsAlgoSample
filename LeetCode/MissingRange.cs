using System;
using System.Collections.Generic;
using System.Text;

namespace DemoConsole.LeetCode
{
   public class MissingRange
    {
        public IList<string> FindMissingRanges(int[] nums, int lower, int upper)
        {

            var res = new List<string>();

            int s = lower;
            foreach (var n in nums)
            {
                if (n >= lower && n <= upper)
                {
                    if ((n - s) == 0)
                    {
                        s++;
                    }
                    else
                    {
                        AddToList(s, n - 1, res);
                        s = n+1;
                    }
                }
            }
            if (nums[nums.Length - 1] < upper && s > nums[nums.Length - 1])
            {
                AddToList(nums[nums.Length - 1] + 1, upper, res);
            }

            return res;
        }
        void AddToList(int s, int e, List<string> list)
        {
            if (s == e)
                list.Add(s.ToString());
            else
                list.Add($"{s}->{e}");
        }
    }
}
