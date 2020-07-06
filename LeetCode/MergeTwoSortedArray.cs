using System;
using System.Collections.Generic;
using System.Text;

namespace DemoConsole.LeetCode
{
    public class MergeTwoSortedArray
    {
        public void Merge(int[] nums1, int m, int[] nums2, int n)
        {
            var t = 0;
            var arr = new int[m];
            int f = 0, s = 0;

            for (int i = 0; i < m; i++)
            {
                arr[i] = nums1[i];

            }

            while (f < m || s < n)
            {

                int a = f < m ? arr[f] : int.MaxValue;
                int b = s < n ? nums2[s] : int.MaxValue;

                if (a < b)
                {
                    nums1[t] = a;
                    f++;
                }
                else
                {
                    nums1[t] = b;
                    s++;
                }

                t++;
            }
        }
    }
}
