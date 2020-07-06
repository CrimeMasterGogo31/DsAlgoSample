using System;
using System.Collections.Generic;
using System.Text;

namespace DemoConsole.LeetCode
{
    public class ReverseWordsInaString
    {
        public string ReverseWords(string s)
        {
            if (s == null)
                return null;

            var arr = s.Split(" ");
            if (arr.Length == 1)
                return arr[0];

            var ans = string.Empty;

            for (int i = arr.Length - 1; i >= 0; i--)
            {
                if (string.IsNullOrEmpty(arr[i]))
                    continue;
                ans += arr[i];

                if (i != 0)
                    ans += " ";
            }
            return ans;
        }
    }
}
