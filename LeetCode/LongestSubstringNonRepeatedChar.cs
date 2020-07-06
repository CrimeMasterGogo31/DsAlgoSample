using System;
using System.Collections.Generic;
using System.Text;

namespace DemoConsole.LeetCode
{
    public class LongestSubstringNonRepeatedChar
    {
        public int LengthOfLongestSubstring(string str)
        {
            var set = new HashSet<char>();
            int e = 0;
            int s = 0;
            int max = 0;
            int count = 0;

            for (; e < str.Length;)
            {
                var c = str[e];
                if (set.Contains(c))
                {
                    max = Math.Max(max, (e-s));
                    while (s<=e) {
                        set.Remove(str[s]);
                        if (str[s] == str[e])
                        {
                            s++;
                            break;
                        }
                        s++;
                    }
                    //count = 0;
                    continue;
                }
                else
                {
                    //count++;
                    set.Add(c);
                    e++;

                }
            }
            max = Math.Max(max, (e - s));

            return max;
        }
    }
}
