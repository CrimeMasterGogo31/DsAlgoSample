using System;
using System.Collections.Generic;
using System.Text;

namespace DemoConsole.LeetCode.maxxor
{
    public class MaxXor
    {
        public int FindMaximumXOR(int[] nums)
        {
            var root = new TrieNode();
            var max = int.MinValue;
            foreach (var num in nums)
                max = Math.Max(num, max);

            var maxbit = 0;

            while (max != 0)
            {
                max = (max >> 1);
                maxbit++;
            }

            foreach (var num in nums)
            {
                var cur = root;
                for (int i = maxbit - 1; i >= 0; i--)
                {
                    var bit = (num >> i) & 1;
                    if (cur.arr[bit] == null)
                    {
                        cur.arr[bit] = new TrieNode();
                    }
                    cur = cur.arr[bit];
                }
            }

            var result = int.MinValue;
            var xor = 0;

            foreach (var num in nums)
            {
                xor = 0;
                var cur = root;
                for (int i = maxbit - 1; i >= 0; i--)
                {
                    var bit = (num >> i) & 1;
                    var flipbit = bit == 1 ? 0 : 1;
                    if (cur.arr[flipbit] == null)
                    {
                        cur = cur.arr[bit];
                    }
                    else
                    {
                        xor += (1 << i);
                        cur = cur.arr[flipbit];
                    }
                }
                result = Math.Max(result, xor);
            }


            return result;

        }
    }

    class TrieNode
    {
        public TrieNode[] arr = new TrieNode[2];
    }
}
