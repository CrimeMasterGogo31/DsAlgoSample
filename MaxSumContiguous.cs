using System;
using System.Collections.Generic;
using System.Text;

namespace DemoConsole
{
    public class MaxSumContiguous
    {
        public int maxSubArray(List<int> A)
        {
            int maxSum = int.MinValue;
            int tempSum = 0;
            // int lasrgestNum = int.MinValue;
            for (int i = 0; i < A.Count; i++)
            {
                for (int j = i,x=0; j < A.Count; j++,x++)
                {
                    tempSum = 0;
                    int limit = (A.Count-1) < j + x ? (A.Count-1) : (j + x);
                    for (int k = j; k <= limit; k++)
                    {
                        tempSum += A[k];
                    }
                    if (tempSum > maxSum)
                    {
                        maxSum = tempSum;
                    }
                }
            }
            return maxSum;
        }
    }
}
