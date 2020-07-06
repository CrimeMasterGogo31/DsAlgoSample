using System;
using System.Collections.Generic;
using System.Text;

namespace DemoConsole.LeetCode
{
    public class BulbSwitch
    {
        public int NumTimesAllBlue(int[] light)
        {
            var arr = new int[light.Length];
            var count = 0;
            var totalOn = 0;
            var totalBlue = 0;
            foreach (var i in light)
            {
                arr[i - 1] = -1;
                totalOn++;
                if (i == 1 || arr[i - 2] == 1)
                {
                    arr[i - 1] = 1;
                    totalBlue++;
                    
                    totalBlue = Update(arr, i, totalBlue);
                    if (totalBlue == totalOn)
                    {
                        count++;
                    }
                }
            }
            return count;

        }
        // -1 =On
        // 1 =blue
        // 0 = off
        int Update(int[] arr, int n, int totalBlue)
        {
            for (int i = n - 1; i < arr.Length - 1; i++)
            {
                if (arr[i + 1] == -1)
                {
                    arr[i + 1] = 1;
                    totalBlue++;
                }
                else
                    break;


            }
            return totalBlue;

        }
    }
}
