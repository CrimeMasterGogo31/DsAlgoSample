using System;

namespace DemoConsole.Gs
{
    public class SqrtClass
    {
        public double Sqrt(int num)
        {
            if(num < 0)
                throw new InvalidOperationException();
            double l = 0;
            double r = num;
            while(l < r)
            {
                var mid = l + ((r -l)/2);
                if( Math.Abs((mid * mid) - num) <= 0.00001)
                {
                    var str = mid.ToString("F5");

                    return Convert.ToDouble(str);
                }
                else if( mid * mid > num)
                {
                    r = mid;
                }
                else 
                {
                    l = mid ;
                }
            }
            return 0;
        }
    }
}