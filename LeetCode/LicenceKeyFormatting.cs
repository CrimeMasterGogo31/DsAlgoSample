using System;
using System.Collections.Generic;
using System.Text;

namespace DemoConsole.LeetCode
{
   public class LicenceKeyFormatting
    {
        public string LicenseKeyFormatting(string S, int K)
        {
            string res = string.Empty;
            // var arrStr = S.Split("-");
            var newS = S.Replace("-", "");
            for (int i = newS.Length - 1; i >= 0;)
            {
                if (i - K+1 > 0)
                {
                    var temp = newS.Substring(i - K+1, K);
                    res = "-"+temp + res;
                    i = i - K;
                }
                else
                {
                    var t = newS.Substring(0, i+1);
                    res = t  + res;
                    break;
                }
            }
            
            return res;
        }
    }
}
