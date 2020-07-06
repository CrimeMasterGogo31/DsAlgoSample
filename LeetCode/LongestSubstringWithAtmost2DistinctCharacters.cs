using System;
using System.Collections.Generic;
using System.Text;

namespace DemoConsole.LeetCode
{
   public class LongestSubstringWithAtmost2DistinctCharacters
    {
        public int LengthOfLongestSubstringTwoDistinct(string str)
        {
            var set = new HashSet<char>();
            var dict = new Dictionary<char, int>();
            int s = 0, e = 0;
            int cur = 0;
            var len = 0;

            while (e < str.Length && s <= e)
            {
                if (dict.ContainsKey(str[e]))
                {
                    dict[str[e]]++;
                    e++;
                }
                else if (cur < 2)
                {
                    cur++;
                    dict.Add(str[e], 1);
                    e++;
                }
                else
                {
                    var t = e - s;
                    len = Math.Max(len, t);

                    while (cur == 2)
                    {
                        dict[str[s]]--;
                        if (dict[str[s]] == 0)
                        {
                            cur--;
                            dict.Remove(str[s]);
                        }
                        s++;
                    }
                }
            }
            len = Math.Max(len, e - s);
            return len;
        }
    }
}
