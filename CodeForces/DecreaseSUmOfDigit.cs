using System;
using System.Collections.Generic;
using System.Text;

namespace DemoConsole.CodeForces
{
    public class DecreaseSUmOfDigit
    {
        //public static void Main()
        //{
        //    int t = Convert.ToInt32(Console.ReadLine().Trim());
        //    while (t-- != 0)
        //    {
        //        var arr = Array.ConvertAll(Console.ReadLine().Trim().Split(' '),
        //            tmp => Convert.ToInt64(tmp));

        //        var n = arr[0];
        //        var s = arr[1];

        //        if (Sum(n) <= s)
        //        {
        //            Console.WriteLine(0);
        //            continue;
        //        }

        //        long res = 0;
        //        var nb = n;
        //        int i = n.ToString().Length;
        //        while (Sum(nb) <= s)
        //        {
        //            var cur = Convert.ToInt64(Math.Pow(10, i));
        //            if (cur > nb)
        //            {
        //                res = cur - n;
        //            }
        //            else
        //            {

        //            }

        //        }


        //    }

        //}

        static int Sum(long n)
        {
            long result = 0;
            while (n != 0)
            {
                result += (n % 10);
                result /= 10;
            }
            return (int)result;
        }
    }
}
