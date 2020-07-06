
namespace DemoConsole.BZ.Contest_2
{
    using System;
    using System.Collections.Generic;

    class BeingZero
    {
        static bool[,] dp = new bool[6, 16];
        //public static void Main(string[] args)
        //{

        //    int sum = Convert.ToInt32(Console.ReadLine());
        //    int size = Convert.ToInt32(Console.ReadLine());
        //    var intput = ReadLineAsIntArray();
        //    if (hasSubsetWithSum(intput, sum))
        //    {
        //        Console.WriteLine("YES");
        //    }
        //    else
        //    {
        //        Console.WriteLine("NO");
        //    }
        //}


        static Dictionary<string, bool> dict = new Dictionary<string, bool>();
        public static bool hasSubsetWithSum(int[] arr, int S)
        {
            int N = arr.Length;
            string key = N + "#" + S;
            if (!(dict.ContainsKey(key)))
            {
                bool res = hasSubsetWithSumRecursive(N, S, arr);
                dict.Add(key, res);
            }
            return dict[key];
        }
        public static bool hasSubsetWithSumRecursive(int N, int S, int[] arr)
        {

            if (S == 0)
            {
                return true;
            }
            if (N == 0 || S < 0)
            {
                return false;
            }

            return hasSubsetWithSumRecursive(N - 1, S - arr[N - 1], arr) || hasSubsetWithSumRecursive(N - 1, S, arr);

        }
        static int[] ReadLineAsIntArray()
        {
            return Array.ConvertAll(Console.ReadLine().Trim().Split(' '), wTemp => Convert.ToInt32(wTemp));
        }
    }
}
