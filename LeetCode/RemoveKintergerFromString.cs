using System;
using System.Collections.Generic;
using System.Text;

namespace DemoConsole.LeetCode
{
    public class RemoveKintergerFromString
    {

        public string RemoveKdigits(string num, int k)
        {
            var list = new List<string>();
            for (int i = 0; i < num.Length - 3; i++)
            {
                Helper(i, k, num, list);
            }
            var arr = list.ToArray();
            Array.Sort(arr, (x, y) => string.Compare(x, y));

            return arr[0];
        }

        void Helper(int ind, int k, string num, List<string> list)
        {
            var copynum = num;
            for (int i = ind; i < num.Length && k > 0; i++)
            {
                if (i == num.Length - 1 || num[i] > num[i + 1])
                    copynum = copynum.Remove(i, 1);
                else
                    copynum = copynum.Remove(i + 1, 1);
                k--;
            }
            while (copynum[0] == '0' && copynum.Length > 0)
            {
                copynum = copynum.Remove(0, 1);
            }
            list.Add(copynum);
        }
    }
}
