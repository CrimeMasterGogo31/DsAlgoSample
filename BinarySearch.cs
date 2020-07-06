using System;
using System.Collections.Generic;
using System.Text;

namespace DemoConsole
{
    public class BinarySearch
    {
        public int DoBinarySearch(int[] arr, int x)
        {
            int left = 0;
            int right = arr.Length - 1;

            while (left <= right)
            {
                int mid = (left + right) / 2;
                if (arr[mid] == x)
                {
                    return mid;
                }
                if (arr[mid] > x)
                {
                    right = mid - 1;
                }
                else
                {
                    left = mid + 1;
                }
            }
            // If not result found then return -1
            return -1;
        }
    }
}
