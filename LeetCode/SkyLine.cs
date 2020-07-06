using System;
using System.Collections.Generic;
using System.Text;

namespace DemoConsole.LeetCode
{
    public class SkyLine
    {
        public IList<IList<int>> GetSkyline(int[][] buildings)
        {
            var curstart = buildings[0][0];
            var curHigh = buildings[0][2];
            var curDip = buildings[0][2];
            var curEnd = buildings[0][1];
            var res = new List<IList<int>>();

            foreach (var b in buildings)
            {
                if (b[2] > curHigh)
                {
                    if (b[1] == curstart)
                    {
                        curHigh = b[2];
                    }
                    else
                    {
                        res.Add(new List<int>() { curstart, curHigh });
                        curHigh = b[2];
                        curstart = b[0];
                    }
                }
                if (b[1] < curEnd && b[2] > curDip)
                {
                    res.Add(new List<int>() { b[1], curEnd });
                }
            }

            return res;
        }
    }
}
