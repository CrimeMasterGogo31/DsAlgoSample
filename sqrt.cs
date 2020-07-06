using System;
using System.Collections.Generic;
using System.Text;

namespace DemoConsole
{
    public class sqrtClass
    {
        public int sqrt(int x) //17 1 2 3 4 5
        {
            var left = 1;
            var right = x;
            int ans=0;
            if (x == 0)
                ans=0;
            else
            {
                while (left <= right)
                {
                    int mid = (left + right) / 2;
                    if (mid <= x / mid)
                    {
                        left = mid + 1;
                        ans = mid;
                    }
                    else {
                        right = mid - 1;
                    }
                }
            }
            return ans;
        }
    }
}

