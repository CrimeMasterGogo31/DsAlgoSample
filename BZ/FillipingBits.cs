using System;
using System.Collections.Generic;
using System.Text;

namespace DemoConsole.BZ
{
    class FillipingBits
    {
        int bitFlipsRequired(int a, int b)
        {
            int n = a ^ b;
            int count = 0;
            while (n != 0)
            {
                if ((n & 1) == 1)
                {
                    count++;
                }
                n = n >> 1;
            }
            return count;
        }
    }
}
