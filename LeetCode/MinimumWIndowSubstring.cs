using System;
using System.Collections.Generic;
using System.Text;

namespace DemoConsole.LeetCode
{
    public class MinimumWIndowSubstring
    {
        public string MinWindow(string str, string t)
        {
            var tdict = new Dictionary<char, int>();
            var sdict = new Dictionary<char, int>();
            foreach (var ch in str)
            {
                if (tdict.ContainsKey(ch))
                    tdict[ch]++;
                else
                    tdict.Add(ch, 1);
            }
            var maxlen = int.MaxValue;
            var result = "";
            int s = 0, e = 0;

            while (s <= (str.Length - t.Length) && e < str.Length)
            {
                var ch = str[e];
                if (tdict.ContainsKey(ch))
                {

                    if (sdict.ContainsKey(ch))
                        sdict[ch]++;
                    else
                        sdict.Add(ch, 1);

                    while (ContainsAllValue(sdict, tdict))
                    {
                        if (maxlen > (e - s + 1))
                        {
                            maxlen = e - s + 1;
                            result = str.Substring(s, e - s + 1);
                        }

                        if (tdict.ContainsKey(str[s]))
                        {
                            sdict[str[s]]--;
                            if (sdict[str[s]] == 0)
                                sdict.Remove(str[s]);
                        }
                        s++;
                    }
                }
                e++;
            }
            return result;
        }

        bool ContainsAllValue(Dictionary<char, int> sdict, Dictionary<char, int> tdict)
        {
            foreach (var kv in tdict)
            {
                if (sdict.ContainsKey(kv.Key) && sdict[kv.Key] >= kv.Value)
                    continue;
                else
                    return false;

            }
            return true;
        }
    }
}
