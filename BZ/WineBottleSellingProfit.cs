using System;
using System.Collections.Generic;
using System.Text;

namespace DemoConsole.BZ
{
    class BZSolution
    {
        static int[] arr;
        Dictionary<string, int> dict;
        public int maxWineSellingProfit(int[] a)
        {
            // Your code here.
            int i = 0;
            int j = a.Length - 1;
            int y = 1;
            arr = a;
            dict = new Dictionary<string, int>();
            return (maxWineSelling(0, j, 1));
        }
        #region BackTracking Approach
        public int maxWineSelling(int i, int j, int y)
        {
            if (i > j)
                return 0;
            if (i == j)
                return arr[i] * y;

            return Math.Max((arr[i] * y) + maxWineSelling(i + 1, j, y + 1),
                               (arr[j] * y) + maxWineSelling(i, j - 1, y + 1));
        }
        #endregion

        #region DP Top Down approach
        public int maxWineSellingDPTD(int i, int j)
        {
            int y = arr.Length - (j - i + 1) + 1;
            if (i > j)
                return 0;
            if (i == j)
                return arr[i] * y;

            string key = i + "," + j;
            if (dict.ContainsKey(key))
                return dict[key];

            int ith = arr[i] * y + maxWineSellingDPTD(i + 1, j);
            int jth = arr[j] * y + maxWineSellingDPTD(i, j - 1);

            return dict[key] = Math.Max(ith, jth);
        }
        #endregion

        public void ComputeWineSellingDP(int i, int j) {

        }


    }
}
