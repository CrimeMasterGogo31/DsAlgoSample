using System;
using System.Collections.Generic;
using System.Text;

namespace DemoConsole.LeetCode
{
    public class Primec
    {
        public int SumFourDivisors(int[] nums)
        {

            var sum = 0;
            foreach (var n in nums)
            {
                var val = getList(n);
                sum += val;
            }
            return sum;
        }

        int getList(int n)
        {
            var list = new HashSet<int>();
            for (int i = 1; i * i <= n; i++)
            {
                if (n % i == 0)
                {
                    list.Add(i);
                    list.Add(n / i);
                }
            }
            var sum = 0;
            if (list.Count == 4)
            {
                foreach (var l in list)
                    sum += l;
            }
            return sum;
        }


    }
}