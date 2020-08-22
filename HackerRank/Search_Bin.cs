using System;
using System.Collections.Generic;
using System.Text;

namespace DemoConsole.HackerRank
{
    class Search_Bin
    {
        //static void Main(String[] args)
        //{
        //    /* Enter your code here. Read input from STDIN. Print output to STDOUT. Your class should be named Solution */
        //    var n = Convert.ToInt32(Console.ReadLine().Trim());

        //    var arr = Array.ConvertAll(Console.ReadLine().Trim().Split(' '),
        // tmp => Convert.ToInt32(tmp));

        //    //2 3 4
        //    //2 5 10

        //    var arrsum = new int[n];
        //    arrsum[0] = arr[0];
        //    for (int i = 1; i < n; i++)
        //        arrsum[i] = arrsum[i-1]+ arr[i];

        //    var q = Convert.ToInt32(Console.ReadLine().Trim());
        //    while (q-- != 0)
        //    {
        //        var coin = Convert.ToInt32(Console.ReadLine().Trim());
        //        Console.WriteLine(binarySearch(arrsum, coin));
        //    }

        //}

        static int binarySearch(int[] arrsum, int coin)
        {
            int s = 0;
            int e = arrsum.Length - 1;
            int ans = 0;
            while (s < e)
            {
                var mid = s + ((e - s) / 2);
                if (arrsum[mid] == coin)
                {
                    return mid;
                }
                else if (arrsum[mid] < coin)
                {
                    s = mid + 1;
                }
                else
                {
                    e = mid - 1;
                    ans = mid;
                }
            }
            return ans;

        }
    }
}
