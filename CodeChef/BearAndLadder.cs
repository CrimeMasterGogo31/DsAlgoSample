using System;
using System.Collections.Generic;
using System.Text;

namespace DemoConsole.CodeChef
{
    class BearAndLadder
    {
        //public static void Main()
        //{
        //    int t = Convert.ToInt32(Console.ReadLine().Trim());
        //    while (t-- != 0)
        //    {
        //        var arr = Array.ConvertAll(Console.ReadLine().Trim().Split(' '),
        //                                 tmp => Convert.ToInt64(tmp));
        //        var f = arr[0];
        //        var s = arr[1];

        //        var fn = GetNeighbour(f);
        //        if (fn.Contains(s))
        //        {
        //            Console.WriteLine("YES");
        //        }
        //        else
        //            Console.WriteLine("NO");
        //    }
        //}

        static List<long> GetNeighbour(long n)
        {
            var res = new List<long>();
            res.Add(n - 2);
            res.Add(n + 2);
            if ((n & 1) == 0)
            {
                res.Add(n - 1);
            }
            else
            {
                res.Add(n + 1);
            }
            return res;
        }
    }
}
