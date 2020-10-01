using System;
using System.Collections.Generic;
using System.Text;

namespace DemoConsole.Gs
{
    public class AddFractionClass
    {
        public int[] AddFractions ( int[] fraction1, int[] fraction2 ) // -2,3   3,2
        {
            if(fraction1 ==null || fraction1[0] ==0)
                return fraction2;
            if(fraction2 == null || fraction2[0] == 0)
                return fraction1;
            if((fraction1.Length > 1 && fraction1[1] ==0) || ( fraction2.Length>1 && fraction2[1]==0))
                return null; // throw divide by zero exception


            int f1n = fraction1[0];
            int f1d = fraction1.Length >1 ? fraction1[1] : 1;
            int f2n = fraction2[0];
            int f2d = fraction2.Length > 1 ? fraction2[1] : 1;
            var  n = (f1n * f2d) + (f2n * f1d);
            var  d = f1d * f2d;

            if(0 == (n % d))
            {
                return new int[]{ n/d};
            }

            var gcd = GCD(n, d);
            n = n/gcd;
            d = d/gcd;
            return new int[]{ n, d};
        }

        // 6, 8 = 2
        int GCD(int a , int b) // check GCD logic for negetive number
        {
            while(a != b)
            {
                if(a > b)
                {
                    a -= b;
                }    
                else
                {
                    b -= a;
                }
            }
            return a;
        }
        
    }
}


