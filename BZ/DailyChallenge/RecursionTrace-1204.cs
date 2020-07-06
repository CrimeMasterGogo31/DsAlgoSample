using System;
using System.Collections.Generic;
using System.Text;

namespace DemoConsole.BeingZero
{
   public class Class1
    {
        public long cd(int n)
        {
            if (n <= 1) {
                return 1;
            }

            long res = 0;
            for (int i= 0; i< n; i++)
            {
                res += cd(i) * cd(n - i - 1);

            }
            return res;

        }
    }
}
