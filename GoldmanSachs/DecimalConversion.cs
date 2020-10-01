using System;
using System.Collections.Generic;

namespace DemoConsole.Gs{
    public class ConversionFraction
    {
        public string vulgarToDecimal(int num, int den) //1/3  0.321321  0.(3)   3>0
        {
            if(0 == den)
                throw new DivideByZeroException();
            if(0 == num)
                return "0";   
            bool isnegetive = false;
            if ((num< 0 && den >0) ||( num > 0 && den < 0))
                isnegetive = true;
                
            long n = Math.Abs((long)num);
            long d = Math.Abs((long)den);
            var res = "";
            res += (n / d).ToString();
            if(isnegetive)
            {
                res = "-" + res;
            }

            if(0 == n % d)
            {
                return res;
            }
            long rem = n % d;
            var dict = new Dictionary<long, long>();
            var decimalpart ="";
            var counter = 0;
            while(rem != 0)
            {
                dict.Add(rem, counter++);
                rem *= 10;
                decimalpart += (rem/d).ToString();
                rem = rem % d;

                if(dict.ContainsKey(rem))
                {
                    decimalpart = decimalpart.Insert((int)dict[rem], "(");
                    decimalpart += ")";
                    break;
                }
            }
            return res + "." + decimalpart ;            
        }
    }

}