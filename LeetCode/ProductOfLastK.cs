using System;
using System.Collections.Generic;
using System.Text;

namespace DemoConsole.LeetCode
{
    class ProductOfNumbers
    {
        List<int> list;
        Dictionary<int, int> dict;

        public ProductOfNumbers()
        {
            this.list = new List<int>();
            this.dict = new Dictionary<int, int>();
        }

        public void Add(int num)
        {
            list.Add(num);
            dict = new Dictionary<int, int>();

        }

        public int GetProduct(int k)
        {
            int temp = k;
            int p = 1;
            int c = list.Count;
            if (dict.ContainsKey(k))
            {
                return dict[k];
            }
            if (dict.Keys.Count > 0)
            {
                int nearest = int.MaxValue;
                foreach (var kv in dict)
                {
                    if ((Math.Abs(kv.Key - k)) < (Math.Abs(kv.Key - nearest)))
                    {
                        nearest = kv.Key;
                    }
                }
                if (nearest < k)
                {
                    p = dict[nearest];
                    c = c - nearest;
                    k = k - nearest;

                }
            }
            while (k-- != 0)
            {
                p *= list[c-- - 1];
            }
            if (!dict.ContainsKey(temp))
                dict.Add(temp, p);
            return p;
        }
    }
}
//2, 20 