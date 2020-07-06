using System;
using System.Collections.Generic;
using System.Text;

namespace DemoConsole.LeetCode
{

    class nextPermutationClass
    {
        public List<int> nextPermutation(List<int> nums)
        {

            int i = nums.Count - 2;
            while (i >= 0 && nums[i + 1] <= nums[i])
            {
                i--;
            }
            if (i >= 0)
            {
                int j = nums.Count - 1;
                while (j >= 0 && nums[j] <= nums[i])
                {
                    j--;
                }
                Swap(nums, i, j);
                Reverse(nums, i + 1);

            }
            else
            {
                Reverse(nums, 0);
            }
            return nums;
        }

        void Reverse(List<int>nums, int i)
        {
            int j = nums.Count - 1;
            while (i < j)
            {
                Swap(nums, i, j);
                i++;
                j--;
            }
        }

        void Swap(List<int> nums, int i, int j)
        {
            var t = nums[i];
            nums[i] = nums[j];
            nums[j] = t;


        }
    }

}
