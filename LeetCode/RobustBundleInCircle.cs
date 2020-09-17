using System;
using System.Collections.Generic;
using System.Text;

namespace DemoConsole.LeetCode
{
    public class RobustBundleInCircle
    {
        public bool IsRobotBounded(string instructions)
        {

            var dirx = new int[4] { -1, 0, 1, 0 };
            var diry = new int[4] { 0, 1, 0, -1 };
            var dir = 0;
            int indx = 0, indy = 0;
            int n = 0;
            while (n++ < 4)
            {
                foreach (var ins in instructions)
                {
                    if (ins == 'L')
                        dir = ((--dir+4) % 4);
                    if (ins == 'R')
                        dir = (++dir % 4);
                    if (ins == 'G')
                    {
                        indx += dirx[dir];
                        indy += diry[dir];
                    }
                }
                if (n == 1 && indx == 0 && indy == 0)
                    return true;
            }

            return indx == 0 && indy == 0 ? true : false;
        }
    }
}
