using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DemoConsole.LeetCode
{
    public class FruitIntoBasket
    {
        public int TotalFruit(int[] tree)
        {
            var s = 0;
            var e = 0;
            var max = 0;
            var cur = 0;
            var dict = new Dictionary<int, int>();
            while (s < tree.Length && e < tree.Length)
            {
                var key = tree[e];
                if (dict.ContainsKey(key))
                {
                    dict[key]++;
                }
                else
                {
                    if (dict.Keys.Count == 2)
                    {
                        foreach (var kv in dict)
                            cur += kv.Value;
                        max = Math.Max(max, cur);
                        while (dict.Keys.Count == 2)
                        {
                            dict[tree[s]]--;
                            if (dict[tree[s]] == 0)
                                dict.Remove(tree[s]);
                            s++;
                        }
                    }
                    dict.Add(tree[e], 1);
                }
                e++;
            }
            foreach (var kv in dict)
                cur += kv.Value;
            max = Math.Max(max, cur);

            return max;
        }


    }

}
