using System;
using System.Collections.Generic;
using System.Text;

namespace DemoConsole.LeetCode
{
   public class CandyClass
    {
        public int Candy(int[] ratings)
        {
            if (ratings == null || ratings.Length == 0)
                return 0;
            if (ratings.Length == 1)
                return 1;
            var n = ratings.Length;
            var leftRight = new int[ratings.Length];
            var rightLeft = new int[ratings.Length];

            for (int i = 0; i < n; i++)
            {
                leftRight[i] = 1;
                rightLeft[i] = 1;
            }
            for (int i = 1; i < n; i++)
            {
                if (ratings[i] > ratings[i - 1])
                    leftRight[i] = leftRight[i - 1] + 1;
            }

            for (int i = n - 2; i >= 0; i--)
            {
                if (ratings[i] > ratings[i + 1])
                    rightLeft[i] = rightLeft[i + 1] + 1;
            }
            int count = 0;
            for (int i = 0; i < n; i++)
            {
                count += Math.Max(rightLeft[i], leftRight[i]);
            }
            return count;
        }
    }
}
