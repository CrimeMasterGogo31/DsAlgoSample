using System;
using System.Collections.Generic;
using System.Text;

namespace DemoConsole.LeetCode
{
   public class BinarySearchRange
    {
        public int[] SearchRange(int[] nums, int target)
        {
            int l = 0, r = nums.Length - 1;
            var ind = -1;
            int m = 0;
            while (l <= r)
            {
                m = l + ((r - l) / 2);
                if (nums[m] == target)
                {
                    ind = m;
                    var left = getleftind(l, m , target, nums);
                    var right = getrightind(m , r, target, nums);
                    return new int[2] { left, right };
                }
                if (nums[m] < target)
                {
                    l = m + 1;
                }
                else
                {
                    r = m - 1;
                }
            }
            return new int[2] { -1, -1 };
        }

        int getleftind(int l, int r, int target, int[] nums)
        {
            int res = r;
            while (l <= r)
            {
                int m = l + ((r - l) / 2);
                if (nums[m] < target)
                {
                    l = m + 1;
                }
                else
                {
                    r = m - 1;
                    res = m;
                }
            }
            return res;
        }

        int getrightind(int l, int r, int target, int[] nums)
        {
            int res = r;
            while (l <= r)
            {
                int m = l + ((r - l) / 2);
                if (nums[m] > target)
                {
                    r = m - 1;
                }
                else
                {
                    l = m + 1;
                    res = m;
                }
            }
            return res;
        }
    }
}
