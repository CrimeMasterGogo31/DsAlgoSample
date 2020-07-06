using System;
using System.Collections.Generic;
using System.Text;

namespace DemoConsole.LeetCode
{
   public class JumpGame
    {
        public int[] memo;
        public bool canJumpFromPosition(int position, int[] nums)
        {
            if (memo[position] != 0)
            {
                return memo[position] > 0 ? true : false;
            }

            int furthestJump = Math.Min(position + nums[position], nums.Length - 1);
            for (int nextPosition = position + 1; nextPosition <= furthestJump; nextPosition++)
            {
                if (canJumpFromPosition(nextPosition, nums))
                {
                    memo[nextPosition] = 1;
                    return true;
                }
            }
            memo[position] = -1;
            return false;
        }

        public bool canJump(int[] nums)
        {
            memo = new int[nums.Length];
            memo[nums.Length - 1] = 1;
            return canJumpFromPosition(0, nums);
        }
    }
}
