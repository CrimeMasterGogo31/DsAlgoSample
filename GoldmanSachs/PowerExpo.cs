using System;
using System.Collections.Generic;
using System.Text;

namespace DemoConsole.Gs
{
    public class PowerClass
    {
        public double Power(double b, int exp) 
        {
            if(0 == b)
                return 0;            
            if(0 == exp)
                return 1;
            if(1 == exp)
                return b;
            if(-1 == exp)
                return 1 / b;

            var ans = Power(b, exp/2);
            return ans * ans * Power(b, exp % 2) ;
        }

    }
}