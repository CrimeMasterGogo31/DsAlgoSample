using System;
using System.Collections.Generic;
using System.Text;

namespace DemoConsole.LeetCode
{
    public class SingleNumberIII
    {
        public int[] SingleNumber(int[] nums)
        {
            int xor = 0;
            foreach (var num in nums)
            {
                xor ^= num;
            }
            var mask = xor & -xor;
            var result = new int[2];
            foreach (var num in nums)
            {
                if ((num & mask) == 0)
                    result[0] ^= num;
                else
                    result[1] ^= num;

            }
            return result;
        }
    }
}
