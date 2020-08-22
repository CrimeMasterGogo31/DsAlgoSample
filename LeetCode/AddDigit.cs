using System;
using System.Collections.Generic;
using System.Text;

namespace DemoConsole.LeetCode
{
    public class AddDigit
    {
        public int AddDigits(int num)
        {
            var sum = 0;
            do
            {
                sum += num % 10;
                num /= 10;
                if (num == 0 && sum > 9)
                {
                    num = sum;
                    sum = 0;
                }
            }
            while (num > 0 && sum > 9);

            return sum;
        }
    }
}
