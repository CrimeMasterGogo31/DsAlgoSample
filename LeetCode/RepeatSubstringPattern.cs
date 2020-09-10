using System;
using System.Collections.Generic;
using System.Text;

namespace DemoConsole.LeetCode
{
    public class RepeatSubstringPattern
    {
        public bool RepeatedSubstringPattern(string s)
        {
            for (int i = 0; i < s.Length / 2; i++)
            {
                if (Validate(i, s))
                    return true;
            }
            return false;
        }

        bool Validate(int ind, string s)
        {
            var len = ind + 1;
            var substr = s.Substring(0, len);

            if (0 != s.Length % len)
                return false;
            var isvalid = true;
            var iterator = s.Length / len;
            var cur = 0;
            while (iterator-- != 0)
            {
                int j = 0;

                while (j < substr.Length && cur < s.Length)
                {
                    if (s[cur++] != substr[j++])
                    {
                        isvalid = false;
                        break;
                    }

                }
                if (!isvalid)
                {
                    return false;
                }
            }
            return true;

        }
    }
}
