using System;
using System.Collections.Generic;
using System.Text;

namespace DemoConsole.LeetCode
{
   public class IsAlphanumericPalindrome
    {
        public bool IsPalindrome(string str)
        {
            if (str == null || str.Length == 1)
                return true;
            int s = 0;
            int e = str.Length - 1;
            bool ispal = true;
            str = str.ToLower();
            while (s < e)
            {
                var sval = str[s];
                var eval = str[e];

                if (!((sval >= 'a' && sval <= 'z') || (sval >= '0' && sval <= '9')))
                {
                    s++;
                    continue;
                }
                if (!((eval >= 'a' && eval <= 'z') && (eval >= '0' && eval <= '9')))
                {
                    e--;
                    continue;
                }
                if (sval != eval)
                {
                    ispal = false;
                    break;
                }
                s++;
                e--;
            }

            return ispal;

        }
    }
}
