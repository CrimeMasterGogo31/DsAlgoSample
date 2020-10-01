using System;

namespace DemoConsole.Gs
{
    public class SmallestNumberClass
    {
        public int FindSmallest(int[] arr)
        {
            int left =0, right = arr.Length-1;
            int min = 0;
            if(arr[left] < arr[right])
                return arr[left];

            while(left < right)
            {
                int mid = left + (right - left)/2;

                if(arr[mid +1] < arr[mid])
                    return arr[mid +1];
                
                if(arr[mid] < arr[mid -1])
                    return arr[mid];

                if(arr[mid] < arr[left])
                {
                    right = mid -1;
                }
                else
                {
                    left = mid + 1;
                }
            }
            
            return min;
        }
    }
}