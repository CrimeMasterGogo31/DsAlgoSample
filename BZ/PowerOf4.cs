using System;
using System.Collections.Generic;
using System.Text;

namespace DemoConsole.BeingZero
{
    class PowerOf4
    {
        bool isPowerOfFour(int n)
        {
            var x = 0x55555555;
            if (!isPowerOfTwo(n))
                return false;

            return (0 != (n & x));
        }

        bool isPowerOfTwo(int n)
        {
            return (0 != n && (0 == (n & n - 1)));
        }
    }
}
