using System;
using System.Collections.Generic;
using System.Text;

namespace DemoConsole.BeingZero
{
    class IsMultipleOf8
    {
        bool isMultipleOfEight(int n)
        {
            return 0 == (n & 7);
        }
    }
}
