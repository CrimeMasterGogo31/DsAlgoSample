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
            int e = 0;
            int recent=0;
            var basket = new Dictionary<int, int>();
            int maxValue = 0;
            while (e < tree.Length)
            {
                if (basket.ContainsKey(tree[e]) || (!basket.ContainsKey(tree[e]) && basket.Count < 2))
                {
                    recent = tree[e];
                    if (basket.ContainsKey(tree[e]))
                    {
                        basket[tree[e++]]++;
                    }
                    else
                    {
                        basket.Add(tree[e++], 1);
                    }
                    continue;
                }
                else
                {
                    var count = basket.Values.ToList().AsQueryable().Sum();
                    maxValue = Math.Max(maxValue, count);
                    foreach (var key in basket.Keys)
                    {
                        if (key != recent)
                        {
                            basket.Remove(key);
                            break;
                        }

                    }
                    recent = tree[e];
                    basket.Add(tree[e++], 1);
                    //basket.Add(tree[e++]);
                }

            }
            maxValue = Math.Max(maxValue, basket.Values.ToList().AsQueryable().Sum());
            return maxValue;

        }

    }

}
