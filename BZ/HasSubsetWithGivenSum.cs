using System;
using System.Collections.Generic;
using System.Text;

namespace DemoConsole.BZ
{
    class HasSubsetWithGivenSum
    {
        static Dictionary<string, bool> dict = new Dictionary<string, bool>();
        public static bool hasSubsetWithSum(int[] arr, int S)
        {
            int N = arr.Length;
            string key = N + "#" + S;
            if (!(dict.ContainsKey(key)))
            {
                bool res = hasSubsetWithSumRecursive(N, S, arr);
                dict.Add(key, res);
            }
            return dict[key];
        }
        public static bool hasSubsetWithSumRecursive(int N, int S, int[] arr)
        {

            if (S == 0)
            {
                return true;
            }
            if (N == 0 || S < 0)
            {
                return false;
            }

            return hasSubsetWithSumRecursive(N - 1, S - arr[N - 1], arr) || hasSubsetWithSumRecursive(N - 1, S, arr);

        }
    }
}
