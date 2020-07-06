using System;
using System.Collections.Generic;
using System.Text;

namespace DemoConsole
{
    class MaximumCOntiguousSubarrySum
    {
        //public static void Main(string[] args)
        //{
        //    int t = ReadInteger();
        //    while (t-- != 0)
        //    {
        //        int noOfElementsOfArray = ReadInteger();
        //        int[] arrayInput = ReadLineAsIntArray();
        //        Console.WriteLine(MaxSum(noOfElementsOfArray, arrayInput));
        //    }
        //}

        public static int MaxSum(int n, int[] arrayInput)
        {
            int max_sum = int.MinValue;
            int sum = 0;

            if (n == 1)
            {
                return arrayInput[n - 1];
            }
            if (n < 1)
            {
                return 0;
            }

            for (int i = 0; i < n; i++)
            {
                sum += arrayInput[i];
                if (sum > max_sum)
                {
                    max_sum = sum;
                }

                if (sum < 0)
                {
                    sum = 0;
                }
            }
            return max_sum;
        }
        static int ReadInteger()
        {
            return Convert.ToInt32(Console.ReadLine());
        }
        static int[] ReadLineAsIntArray()
        {
            return Array.ConvertAll(Console.ReadLine().Trim().Split(' '), wTemp => Convert.ToInt32(wTemp));
        }
    }
}
