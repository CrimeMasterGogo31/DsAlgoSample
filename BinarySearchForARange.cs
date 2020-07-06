using System;
using System.Collections.Generic;
using System.Text;

namespace DemoConsole
{
    //Given a sorted array of integers, find the starting and ending position of a given target value.
    //Your algorithm’s runtime complexity must be in the order of O(log n).
    //If the target is not found in the array, return [-1, -1].

    //Example:

    //Given[5, 7, 7, 8, 8, 10]

    //and target value 8,

    //return [3, 4].
    public class BinarySearchForARange
    {
        public int[] DoBinarySearchForARange(int[] A, int b)
        {
            int left = 0;
            int right = A.Length - 1;
            //int l_range = -1, r_range = -1;
            int[] range = { -1, -1 };
            while (left <= right)
            {
                int mid = (left + right) / 2;
                if (A[mid] == b)
                {
                    range[0] = DoleftBinarySearch(A, left, mid - 1, b);
                    range[1] = DorightBinarySearch(A, mid + 1, right, b);
                    return range;
                }
                if (A[mid] > b)
                {
                    right = mid - 1;
                }
                else
                {
                    left = mid + 1;
                }
            }
            return range;
        }
        public int DoleftBinarySearch(int[] arr, int left, int right, int x)
        {
            //int left = 0;
            //int right = arr.Length - 1;     1 ,1,3,3,3,3
            int ans = 0;
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
            // If not result found then return -1
            return ans;
        }

        public int DorightBinarySearch(int[] arr, int left, int right, int x)
        {
            //int left = 0;
            //int right = arr.Length - 1;
            int ans = 0;
            while (left <= right)
            {
                int mid = (left + right) / 2;
                //2               3
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
            // If not result found then return -1
            return ans;
        }
    }
}
