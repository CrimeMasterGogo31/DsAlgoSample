using System;
using System.Collections.Generic;
using System.Text;

namespace DemoConsole.LeetCode
{
    public class coinCollectionII
    {
        public int CoinChange(int[] coins, int amount)
        {
            var res = DP(coins, amount, coins.Length - 1);
            if (res == int.MaxValue)
                return -1;
            return res;
        }

        int DP(int[] coins, int sum, int n)
        {
            if (sum == 0)
                return 0;
            if (sum < 0 || n < 0 || coins[n] > sum)
                return 10000000;

            return Math.Min(1 + DP(coins, sum - coins[n], n),
                            Math.Min(1 + DP(coins, sum - coins[n], n - 1),
                            DP(coins, sum, n - 1))
                            );
        }
    }
}
