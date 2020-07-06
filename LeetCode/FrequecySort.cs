using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DemoConsole.LeetCode
{
    public class FrequecySort
    {
        public string FrequencySort(string s)
        {

            var dict = new Dictionary<int, int>();

            foreach (var c in s)
            {
                int charInt = c - 'a';
                if (dict.ContainsKey(charInt))
                    dict[charInt]++;
                else
                    dict.Add(charInt, 1);
            }

            int[][] arr = new int[dict.Count][];

            int i = 0;
            foreach (var k in dict.Keys.ToArray())
                arr[i++] = new int[2] { k, dict[k] };

            Array.Sort(arr, (x, y) => y[1] - x[1]);

            string res = "";
            foreach (var a in arr)
            {
                while (a[1]-- != 0)
                {
                    res += ((char)(a[0] + 'a')).ToString();
                }
            }
            return res;
        }
    }
}
