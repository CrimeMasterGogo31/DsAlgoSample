using System;
using System.Collections.Generic;
using System.Text;

namespace DemoConsole.LeetCode
{
    public class SolutionLeetCode173
    {
        public IList<int> FilterRestaurants(int[][] restaurants, int veganFriendly, int maxPrice, int maxDistance)
        {
            var filtered = new List<int[]>();
            if (veganFriendly == 1)
            {
                foreach (var res in restaurants)
                {
                    if (res[2] == veganFriendly && res[3] <= maxPrice && res[4] <= maxDistance)
                        filtered.Add(new int[] { res[0], res[1] });
                }
            }
            else {
                foreach (var res in restaurants)
                {
                    if ( res[3] <= maxPrice && res[4] <= maxDistance)
                        filtered.Add(new int[] { res[0], res[1] });
                }
            }

            var cmp = new Cmp();
            var arr = filtered.ToArray();
            Array.Sort(arr, cmp);
            var resList = new List<int>();
            foreach (var r in arr)
                resList.Add(r[0]);

            return resList;
        }
    }

    public class Cmp : IComparer<int[]>
    {
        public int Compare(int[] x, int[] y)
        {
            if (x[1] == y[1])
                return y[0] - x[0];
            else
                return y[1] - x[1];
        }
    }
}
