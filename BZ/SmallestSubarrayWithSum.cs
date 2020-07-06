using System;
using System.Collections.Generic;
using System.Text;

namespace DemoConsole.BZ
{
    class SmallestSubarrayWithSumClass
    {
        //public static void Main(string[] args)
        //{
        //    int t = Convert.ToInt32(Console.ReadLine());
        //    while (t-- != 0)
        //    {
        //        int size = Convert.ToInt32(Console.ReadLine());
        //        int[] a = new int[size];
        //        if (size > 0)
        //        {
        //            string[] parts = Console.ReadLine().Split(' ');
        //            int count = 0;
        //            foreach (string p in parts)
        //                a[count++] = Convert.ToInt32(p);

        //        }
        //        int query = Convert.ToInt32(Console.ReadLine());
        //        int[] queries = new int[size];

        //        string[] line = Console.ReadLine().Split(' ');
        //        int i = 0;
        //        foreach (string p in line)
        //        {
        //            Console.Write(SmallestSubarrayWithSum(a, Convert.ToInt32(p)) + " ");
        //        }
        //    }
        //}

        private static int SmallestSubarrayWithSum(int[] a, int sum)
        {
            List<int> l = new List<int>();
            int arrLen = int.MaxValue, arrSum = a[0];
            for (int s = 0, e = 0; e < a.Length && s < a.Length;)
            {

                if (arrSum < sum )
                {
                    if (e < a.Length - 1)
                    {
                        arrSum += a[++e];
                    }
                    else {
                        e++;
                    }
                    continue;
                }
                if (arrSum >= sum)
                {
                    var len = e - s + 1;
                    if (len < arrLen)
                    {
                        arrLen = len;
                    }
                    arrSum -= a[s++];
                }
            }
            if (arrLen > a.Length)
                return -1;
            else
                return arrLen;
        }
    }
}
