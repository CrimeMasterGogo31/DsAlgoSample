using System;
using System.Collections.Generic;
using System.Text;

namespace DemoConsole.BeingZero
{
    public class FrequencyOfaNumberInaSortedArray
    {
        public int findFreq(int[] a, int k)
        {
            int left = 0;
            int right = a.Length - 1;
            int count = 0;
            while (left <= right)
            {
                int mid = ((right - left) / 2) + left;
                if (a[mid] > k)
                {
                    right = mid - 1;
                }
                else if(a[mid] < k)
                {
                    left = mid + 1;
                }
                else if (a[mid] == k)
                {
                    count++;

                    var l_res = DoleftBinarySearch(a, left, mid - 1, k);
                    if (l_res != -1)
                    {
                        count += mid - l_res;
                    }
                    var r_res = DorightBinarySearch(a, mid + 1, right, k);
                    if (r_res != -1)
                    {
                        count += r_res - mid;
                    }
                    return count;
                }
            }

            return count;
        }

        public int DoleftBinarySearch(int[] arr, int left, int right, int x)
        {
            int ans = -1;
            while (left <= right)
            {
                int mid = (left + right) / 2;

                if (arr[mid] < x)
                {
                    left = mid + 1;

                }
                else
                {
                    right = mid - 1;
                    ans = mid;
                }
            }

            return ans;
        }

        public int DorightBinarySearch(int[] arr, int left, int right, int x)
        {

            int ans = -1;
            while (left <= right)
            {
                int mid = (left + right) / 2;
                if (arr[mid] > x)
                {
                    right = mid - 1;

                }
                else
                {
                    left = mid + 1;
                    ans = mid;
                }
            }

            return ans;
        }
    }
}
