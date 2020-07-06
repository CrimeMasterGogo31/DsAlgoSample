using System;
using System.Collections.Generic;
using System.Text;

namespace DemoConsole.HackerRank
{
    public class GetSumOfDigitHelper : IComparer<int>
    {
        public int Compare(int x, int y)
        {
            int curSum = GetSumOfDigit(x);
            int nextSum = GetSumOfDigit(y);
            if (curSum == nextSum)
            {
                return y - x;
            }
            else
                return curSum - nextSum;
        }
        static int GetSumOfDigit(int n)
        {
            int sum = 0;
            while (n != 0)
            {
                sum += n % 10;
                n = n / 10;
            }
            return sum;

        }
    }
    class DigitSumSortClass
    {

        //static int sum = 0;
        //static void Main(String[] args)
        //{
        //    /* Enter your code here. Read input from STDIN. Print output to STDOUT. Your class should be named Solution */
        //    int t = Convert.ToInt32(Console.ReadLine());

        //    string[] strInp = Console.ReadLine().Split(' ');
        //    int[] arr = Array.ConvertAll(strInp, Int32.Parse);

        //    //var res = DigitSumSort(arr);
        //    var cmp = new GetSumOfDigitHelper();
        //    Array.Sort(arr, cmp);

        //    for (int i = 0; i <= arr.Length - 1; i++)
        //    {
        //        Console.Write(arr[i] + " ");
        //    }
        //}

    }
}
