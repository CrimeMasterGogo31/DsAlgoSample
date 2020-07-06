using System;
using System.Collections.Generic;
using System.Text;

namespace DemoConsole.HackerRank
{
    class ArraySum
    {
        static long modSum(long a, long b)
        {
            int M = (int)1e9 + 7;
            return ((a % M + b % M) % M);
        }
        //static void Main(String[] args)
        //{
        //    int t = Convert.ToInt32(Console.ReadLine());
        //    while (t-- != 0)
        //    {
        //        long sum = 0;
        //        int len = Convert.ToInt32(Console.ReadLine());
        //        var arr = Array.ConvertAll(Console.ReadLine().Trim().Split(' '), wTemp => Convert.ToInt64(wTemp));

        //        for (int i = 0; i < len; i++) {

        //            sum = modSum(sum , arr[i]);

        //        }

        //        Console.WriteLine(sum);
        //    }
        //}
    }
}
