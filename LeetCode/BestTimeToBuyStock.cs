using System;
using System.Collections.Generic;
using System.Text;

namespace DemoConsole.LeetCode
{
   public class BestTimeToBuyStock
    {
        public int MaxProfit(int[] prices)
        {
            int[] lefttoright = new int[prices.Length];
            int[] righttoleft = new int[prices.Length];

            for (int i = 0; i < prices.Length - 1; i++)
            {
                lefttoright[i] = int.MaxValue;
                righttoleft[i] = int.MinValue;
            }

            lefttoright[0] = prices[0];
            for (int i = 1; i < prices.Length; i++)
            {
                lefttoright[i] = Math.Min(prices[i], lefttoright[i - 1]);
            }

            righttoleft[prices.Length - 1] = prices[prices.Length - 1];

            for (int i = prices.Length - 2; i >= 0; i--)
            {
                righttoleft[i] = Math.Max(prices[i], righttoleft[i + 1]);
            }

            var max = 0;
            for (int i = 0; i < prices.Length; i++)
            {
                var cur = righttoleft[i] - lefttoright[i];
                max = Math.Max(cur, max);
            }
            return max;
        }
    }
}
