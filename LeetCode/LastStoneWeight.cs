using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DemoConsole.LeetCode
{
    class LastStoneWeightClass
    {
        public int LastStoneWeight(int[] stones)
        {
            if (stones == null || stones.Length == 0)
                return 0;
            if (stones.Length == 1)
                return stones[0];
            if (stones.Length == 2)
                return Math.Abs(stones[1] - stones[0]);

            var dict = new SortedDictionary<int, int>(Comparer<int>.Create((x, y) => y - x));
            foreach (var s in stones)
            {
                if (dict.ContainsKey(s))
                    dict[s]++;
                else
                    dict.Add(s, 1);
            }
            while (dict.Keys.Count > 1)
            {
                int diff = 0;
                var f = dict.First();
                if (f.Value > 1)
                {
                    if (dict[f.Key] > 2)
                        dict[f.Key] -= 2;
                    else
                        dict.Remove(f.Key);
                }
                else
                {
                    var s = dict.Skip(1).First();
                    diff = Math.Abs(f.Key - s.Key);
                    if (dict.ContainsKey(diff))
                        dict[diff]++;
                    else
                        dict.Add(diff, 1);

                    dict.Remove(f.Key);

                    if (dict[s.Key] > 1)
                        dict[s.Key]--;
                    else
                        dict.Remove(s.Key);
                }
            }

            if (dict.First().Value % 2 != 0)
                return dict.First().Key;
            else
                return 0;
        }
    }
}
