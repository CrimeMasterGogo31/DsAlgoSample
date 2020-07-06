using System;
using System.Collections.Generic;
using System.Text;

namespace DemoConsole.LeetCode
{
    public class SortColorClass
    {
        public void SortColors(int[] nums)
        {
            int zp = 0;
            int cur = 0;
            int tp = nums.Length - 1;

            while (cur < nums.Length && cur <= tp)
            {
                if (nums[cur] == 0)
                {
                    if (cur == zp)
                    {
                        zp++;
                    }
                    else
                    {
                        var tmp = nums[cur];
                        nums[cur] = nums[zp];
                        nums[zp] = tmp;
                        zp++;
                        continue;
                    }
                }
                else if (nums[cur] == 2)
                {
                    if (tp == cur)
                    {
                        break;
                    }
                    else
                    {
                        var tmp = nums[cur];
                        nums[cur] = nums[tp];
                        nums[tp] = tmp;
                        tp--;
                        continue;
                    }
                }
                cur++;
            }

        }
    }
}
