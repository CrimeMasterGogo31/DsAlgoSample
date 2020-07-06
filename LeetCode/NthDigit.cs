using System;
using System.Collections.Generic;
using System.Text;

namespace DemoConsole.LeetCode
{
    public class NthDigit
    {
        public int FindNthDigit(int num)
        {
            if (num == 0)
                return 0;
            long sum = 0;
            var currentSize = 0;
            for (int n = 1; n < 32; n++)
            {
                sum += 9 * Convert.ToInt64(Math.Pow(10, n - 1));
                if (sum >= num)
                {
                    currentSize = n;
                    sum -= 9 * n* Convert.ToInt64(Math.Pow(10, n - 1));
                    break;
                }
            }
            int digits = (int)(num - sum) / currentSize;
            var rem = (num - sum) % currentSize;

            if (digits == 0 && rem==0)
                return 9;
            var cur = Math.Pow(10, currentSize-1);
            for (int i = 1; i < digits; i++)
            {
                cur++;
            }

            if (rem == 0)
                return (int)cur % 10;
            else
            {
                cur++;
                return (int)(cur / (int)Math.Pow(10, currentSize - rem) % 10);
            }
        }
    }
}
