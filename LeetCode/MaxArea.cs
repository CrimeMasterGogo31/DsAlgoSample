using System;
using System.Collections.Generic;
using System.Text;

namespace DemoConsole.LeetCode
{
    public class MaxAreaClass
    {
        static Dictionary<string, int> d = new Dictionary<string, int>();
        public int MaxArea(int[] height)
        {

            var res = DP(0, height.Length - 1, height);
            return res;

        }

        int DP(int s, int e, int[] height)
        {
            if (s >= e)
                return 0;
            //var key = $"{s}#{e}";
            var h = Math.Min(height[s], height[e]);
            var area = h * (e - s);

            return Math.Max(
                area, Math.Max(
                    DP(s + 1, e, height),
                    Math.Max(
                        DP(s, e - 1, height),
                        DP(s + 1, e - 1, height))));
        }
    }
}
