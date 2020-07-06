using System;
using System.Collections.Generic;
using System.Text;

namespace DemoConsole
{
    public class LongestSubstringWithoutRepeatingCharacter
    {
        public int LengthOfLongestSubstring(string s)
        {
            int max_len = 0;
            int cur_len = 0;
            List<Char> visitedIndex = new List<char>();

            string cur_substring = string.Empty;

            for (int i = 0; i < s.Length; i++)
            {
                if (!visitedIndex.Contains(s[i]))
                {
                    cur_len++;
                    visitedIndex.Add(s[i]);
                    cur_substring = cur_substring + s[i];
                }
                else
                {
                    if (!cur_substring.Contains(s[i]))
                    {
                        cur_len++;
                        cur_substring = cur_substring + s[i];
                    }
                    else
                    {
                        //cur_substring = s[i].ToString();
                        cur_substring=cur_substring.Substring(cur_substring.IndexOf(s[i])+1);
                        cur_substring = cur_substring + s[i];
                        if (cur_len > max_len)
                        {
                            max_len = cur_len;
                        }
                        cur_len= cur_substring.Length;
                    }
                }
              
            }
            if (cur_len > max_len)
            {
                max_len = cur_len;
            }
            return max_len;

        }

    }
}
