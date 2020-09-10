using System;
using System.Collections.Generic;
using System.Text;

namespace DemoConsole.LeetCode
{
   public class PanCakeSort
    {
        public IList<int> PancakeSort(int[] A)
        {

            var list = new List<int>();
            for (int i = A.Length; i > 0; i--)
            {
                var index = GetIndex(A, i);
                if (index + 1 == i)
                    continue;
                else
                {
                    if (index == 0 && i == 1)
                        break;
                    if (index == 0)
                    {
                        Reverse(A, i - 1);
                        list.Add(i);
                        continue;
                    }
                    Reverse(A, index);
                    list.Add(index + 1);
                    Reverse(A, i - 1);
                    list.Add(i);

                }
            }
            return list;
        }

        int GetIndex(int[] arr, int val)
        {
            for (int i = 0; i < arr.Length; i++)
                if (arr[i] == val)
                    return i;
            return -1;
        }

        void Reverse(int[] arr, int ind)
        {
            int s = 0, e = ind;
            while (s < e)
            {
                var t = arr[e];
                arr[e] = arr[s];
                arr[s] = t;
                s++;
                e--;
            }
        }
    }
}
