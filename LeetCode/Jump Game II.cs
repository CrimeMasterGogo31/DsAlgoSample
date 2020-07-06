using System.Collections.Generic;
using System.Text;

namespace DemoConsole.LeetCode
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    //namespace DemoConsole.LeetCode
    //{
    //    //public class JumpGameII
    //    //{
    //    //    public int[] memo;
    //    //    public int canJumpFromPosition(int position, int[] nums, int curJump)
    //    //    {
    //    //        if (memo[position] != 0)
    //    //        {
    //    //            return memo[position];
    //    //        }
    //    //        var minJump = int.MaxValue;
    //    //        int furthestJump = Math.Min(position + nums[position], nums.Length - 1);
    //    //        for (int nextPosition = position + 1; nextPosition <= furthestJump; nextPosition++)
    //    //        {
    //    //            var jumpFromThisPoint = canJumpFromPosition(nextPosition, nums, curJump + 1);
    //    //                if (jumpFromThisPoint > 0)
    //    //            {
    //    //                memo[nextPosition] = curJump +Math.Min(minJump, jumpFromThisPoint);
    //    //            }
    //    //            //return true;
    //    //        }
    //    //        memo[position] = -1;
    //    //        return false;
    //    //    }

    //    //    public int canJump(int[] nums)
    //    //    {
    //    //        memo = new int[nums.Length];
    //    //        memo[nums.Length - 1] = 1;
    //    //        return canJumpFromPosition(0, nums, 0);
    //    //    }
    //    //}
    //}

}
