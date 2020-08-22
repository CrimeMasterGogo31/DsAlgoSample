using System;
using System.Collections.Generic;
using System.Text;

namespace DemoConsole.LeetCode
{
    public class FindMinimum
    {
        public int FindMin(int[] nums)
        {
            if (nums.Length == 1)
                return nums[0];
            var min = int.MaxValue;
            int l = 0, r = nums.Length - 1;
            if (nums[l] < nums[r])
                return nums[l];
            while (l <= r)
            {
                var mid = l + ((r - l) / 2);
                if (nums[mid] < nums[r] && nums[l] < nums[mid])
                {
                    min = nums[l];
                    break;
                }
                else if (nums[mid] > nums[r])
                {
                    min = nums[r];
                    l = mid + 1;
                }
                else if (nums[mid] < nums[l]) // 7 1 2 3 4 5 6
                {
                    min = nums[mid];
                    r = mid - 1;
                }

            }
            return min;
        }
    }
}
