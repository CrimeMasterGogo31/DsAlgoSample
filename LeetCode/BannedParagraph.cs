using System;
using System.Collections.Generic;
using System.Text;

namespace DemoConsole.LeetCode
{
    public class BannedParagraph
    {
        public string MostCommonWord(string paragraph, string[] banned)
        {
            var banset = new HashSet<string>();
            foreach (var ban in banned)
            {
                banset.Add(ban);
            }

            var dict = new Dictionary<string, int>();

            var arr = paragraph.Split(" ");
            var maxlen = 0;
            var res = "";
            int s = 0;
            for (int i = 0; i < paragraph.Length; i++)
            {
                var ch = paragraph[i];
                if (ch == '!' || ch == '\'' || ch == '?' || ch == ',' || ch == ';' || ch == '.' || ch == ' ')
                {
                    var temp = paragraph.Substring(s, i - s);
                    if (s == i)
                    {
                        s++;
                        continue;
                    }
                    s = i + 1;

                    temp = temp.ToLower();
                    if (!banset.Contains(temp))
                    {
                        if (dict.ContainsKey(temp))
                            dict[temp]++;
                        else
                            dict.Add(temp, 1);

                        if (dict[temp] > maxlen)
                        {
                            maxlen = dict[temp];
                            res = temp;
                        }
                    }
                }
            }

            if (s != paragraph.Length)
            {
                var temp = paragraph.Substring(s, paragraph.Length - s);
                temp = temp.ToLower();
                if (!banset.Contains(temp))
                {
                    if (dict.ContainsKey(temp))
                        dict[temp]++;
                    else
                        dict.Add(temp, 1);

                    if (dict[temp] > maxlen)
                    {
                        maxlen = dict[temp];
                        res = temp;
                    }
                }
            }

            return res;
        }

    }



}
