using System;
using System.Collections.Generic;
using System.Text;

namespace DemoConsole.LeetCode
{
    public class PrintPermutation
    {
        HashSet<int> set;
        public IList<IList<int>> Permute(int[] nums)
        {
            var res = new List<IList<int>>();
            set = new HashSet<int>();
            Compute(nums, new List<int>(), res);

            return res;
        }

        void Compute(int[] nums, List<int> cur, List<IList<int>> res)
        {
            if (cur.Count == 3)
            {
                res.Add(cur);
                cur = new List<int>();
                return;
            }
            foreach (var n in nums)
            {
                if (set.Contains(n))
                    continue;

                cur.Add(n);
                set.Add(n);
                Compute(nums, cur, res);
                set.Remove(n);
                cur.RemoveAt(cur.Count - 1);
            }
        }
    }
}
