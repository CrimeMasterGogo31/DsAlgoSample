using System;
using System.Collections.Generic;
using System.Text;

namespace DemoConsole.LeetCode
{
    public class BestTimeToBuyStockIII
    {
        int max;
        #region Recurrsion Apprach 
        public int MaxProfit(int[] prices)
        {
            max = 0;

            Calculate(prices, 0, true, 0, 0);
            return max;
        }

        void Calculate(int[] prices, int idx, bool canbuy, int sellcount, int profit, int buyPrice = 0)
        {
            if (idx == prices.Length)
                return;
            if (canbuy)
            {
                Calculate(prices, idx + 1, false, sellcount, profit, prices[idx]);// buy
                Calculate(prices, idx + 1, true, sellcount, profit, 0); // did not buy 
            }
            else
            {
                Calculate(prices, idx + 1, false, sellcount, profit, buyPrice); // did not sell
                if (prices[idx] > buyPrice)
                {
                    profit += prices[idx] - buyPrice;
                    max = Math.Max(max, profit);
                    if (++sellcount == 2)
                    {
                        return;
                    }
                    Calculate(prices, idx + 1, true, sellcount, profit, 0); // sell

                }

            }
        }
        #endregion
        public int MaxProfit2(int[] prices)
        {
            var len = prices.Length;
            var leftmin = int.MaxValue;
            var leftprofit = new int[len];
            var rightmax = int.MinValue;
            var rightprofit = new int[len];
            for (int i = 1; i < len; i++)
            {
                leftmin = Math.Min(prices[i], leftmin);
                leftprofit[i] = Math.Max(leftprofit[i - 1], prices[i] - leftmin);
            }
            for (int i = len - 2; i >= 0; i--)
            {
                rightmax = Math.Max(prices[i], rightmax);
                rightprofit[i] = Math.Max(rightprofit[i + 1], rightmax - prices[i]);
            }
            var maxprofit = 0;

            for (int i = 0; i < len - 1; i++)
            {
                maxprofit = Math.Max(maxprofit, leftprofit[i] + rightprofit[i + 1]);
            }
            return maxprofit;
        }
    }


}
