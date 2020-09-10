using System;
using System.Collections.Generic;
using System.Text;

namespace DemoConsole.LeetCode
{
    public class TrapingRainWater
    {
        public int Trap(int[] height)
        {
            var tap = 0;

            int s = 0, e = 0;
            int startheight = 0;
            while (s < height.Length && e < height.Length)
            {
                if (height[e] > startheight)
                {
                    if (s == e)
                    {
                        s = e;
                        startheight = height[e];
                        continue;
                    }
                    else
                    {
                        tap += calculate(s, e, height, startheight);
                        s = e;
                        startheight = height[e];
                    }
                }
                e++;
            }

            if (e - s > 1)
            {
                tap += calculate(s, e - 1, height, startheight);
            }
            return tap;
        }

        int calculate(int s, int e, int[] height, int startheight)
        {
            if (startheight == 0)
                return 0;
            var tap = 0;
            var tapstack = new Stack<int>();
            var minstack = new Stack<int>();
            while (e != s)
            {
                if (tapstack.Count == 0)
                {
                    minstack.Push(height[e]);
                }
                else
                {
                    minstack.Push(Math.Max(height[e], minstack.Peek()));
                }
                tapstack.Push(height[e--]);
            }

            while (tapstack.Count >1)
            {
                var cur = tapstack.Pop();
                tap += (Math.Min(minstack.Peek(), startheight) - cur);
                minstack.Pop();
            }
            return tap;
        }
    }
}
