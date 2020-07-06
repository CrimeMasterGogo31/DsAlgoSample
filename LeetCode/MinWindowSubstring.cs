using System;
using System.Collections.Generic;
using System.Text;

namespace DemoConsole.LeetCode
{
    public class MinWindowSubstring
    {
        public string MinWindow(string str, string t)
        {
            if (str == "" || t == "")
                return "";

            int s = 0;
            int e = 0;
            var dictT = new Dictionary<char, int>();
            var windowT = new Dictionary<char, int>();
            foreach (var c in t)
            {
                if (dictT.ContainsKey(c))
                    dictT[c]++;
                else
                    dictT.Add(c, 1);
            }
            var required = dictT.Count;
            var formed = 0;
            string minStr = "";
            int minLength = int.MaxValue;
            while(e<str.Length )
            {

                var c = str[e];
                if (windowT.ContainsKey(c))
                    windowT[c]++;
                else
                    windowT.Add(c, 1);
                // temp += c;
                if (dictT.ContainsKey(c) && dictT[c] == windowT[c])
                {
                    formed++;
                }

                while (s <= e && formed == required)
                {
                    var len = e - s;
                    if (len < minLength)
                    {
                        minLength = len;
                        minStr = str.Substring(s, e-s);
                    }
                    var cc = str[s];
                    windowT[cc]--;
                    if (dictT.ContainsKey(cc) && dictT[cc] > windowT[cc])
                    {
                        formed--;
                    }
                    s++;
                }
                e++;
            }
            return minStr;
        }
    }
}
