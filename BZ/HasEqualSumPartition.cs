using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DemoConsole.BZ
{
    class HasEqualSumPartition
    {

        static Boolean[,] dp;
        public bool hasEqualSumPartitions(int[] arr)
        {
            int sum = 0;
            for (int i = 0; i <= arr.Length - 1; i++)
            {
                sum += arr[i];
            }
            if (!((sum % 2) == 0))
                return false;
            int sumhalf = sum / 2;
            dp = new Boolean[sumhalf + 1, arr.Length + 1];
            ComputeMatrix(sumhalf, arr);

            return dp[sumhalf, arr.Length];
        }
        public static void ComputeMatrix(int s, int[] a)
        {
            int n = a.Length;

            // where i = sum;
            for (int i = 0, j = 0; j <= n; j++)
            {
                dp[i, j] = true;
            }
            for (int i = 1, j = 0; i <= s; i++)
            {
                dp[i, j] = false;
            }

            for (int i = 1; i <= s; i++)
            {
                for (int j = 1; j <= n; j++)
                {

                    if ((i >= a[j - 1]) && j - 1 >= 0)
                        dp[i, j] = dp[i, j] || dp[i - a[j - 1], j - 1];
                    dp[i, j] = dp[i, j] || dp[i, j - 1];
                }
            }
        }

    }
    class Test
    {
//        public static void Main(string[] args)
//        {
//            int t = ReadLineAsInt();
//            HasEqualSumPartition bz = new HasEqualSumPartition();
//            while (t-- != 0)
//            {
//#pragma warning disable
//                int n = ReadLineAsInt();
//#pragma warning restore
//                int[] arr = ReadLineAsIntArray();

//                Console.WriteLine(bz.hasEqualSumPartitions(arr) ? "true" : "false");
//            }
//        }
        static int ReadLineAsInt()
        {
            return Convert.ToInt32(Console.ReadLine().Trim());
        }
        static int[] ReadLineAsIntArray()
        {
            return Array.ConvertAll(Console.ReadLine().Trim().Split(' '), wTemp => Convert.ToInt32(wTemp));
        }

        static List<int> ReadLineAsIntList()
        {
            int[] a = ReadLineAsIntArray();
            return a.OfType<int>().ToList();
        }
    }
}
