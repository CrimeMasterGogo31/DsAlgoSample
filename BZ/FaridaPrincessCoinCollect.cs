using System;
using System.Collections.Generic;
using System.Text;

namespace DemoConsole.BZ
{
    public class Test1
    {
        static long[] arr;
        static long[] Dp = new long[1001];

        //public static void Main()
        //{
        //    long t = Convert.ToInt32(Console.ReadLine());
        //    for (int i = 1; i <= t; i++)
        //    {
        //        string[] lenStr = Console.ReadLine().Split(' ');
        //        long len = Array.ConvertAll(lenStr, long.Parse)[0];
        //        arr = new long[len];
        //        Array.Fill(Dp, -1);
        //        string[] arrStr = Console.ReadLine().Split(' ');
        //        arr = Array.ConvertAll(arrStr, long.Parse);
        //        Console.WriteLine("Case " + i + ": " + CollectCoin(arr.Length));
        //    }
        //}

        #region BackTracking
        public static long CollectCoin(long n)
        {
            if (n <= 0)
            {
                return 0;
            }

            return Math.Max(arr[n - 1] + CollectCoin(n - 2), CollectCoin(n - 1));

        }
        #endregion
    }
}
