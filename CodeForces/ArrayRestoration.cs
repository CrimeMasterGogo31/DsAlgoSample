using System;
using System.Collections.Generic;
using System.Text;

namespace DemoConsole.CodeForces
{
    public class ArrayRestoration
    {
        //public static void Main()
        //{
        //    int t = Convert.ToInt32(Console.ReadLine().Trim());
        //    while (t-- != 0)
        //    {
        //        var arr = Array.ConvertAll(Console.ReadLine().Trim().Split(' '),
        //            tmp => Convert.ToInt64(tmp));
        //        var n = arr[0];
        //        var x = arr[1];
        //        var y = arr[2];

        //        if (n == 2)
        //        {
        //            Console.WriteLine(x + " " + y);
        //            continue;
        //        }
        //        if ((y - x) % (n - 1) == 0)
        //        {
        //            Console.Write(x);
        //            var tmp = x + n;
        //            while (tmp <= y)
        //            {
        //                Console.Write(" " + tmp);
        //                tmp += n;
        //            }
        //            Console.WriteLine();
        //            continue;
        //        }
        //        var diff = y - x;
        //        var newlimit = 2;
        //        while (newlimit < n)
        //        {
        //            if (diff % newlimit == 0)
        //                break;
        //            newlimit++;
        //        }

        //        Console.Write(x);
        //        var count = 1;
        //        var temp = x;
        //        while (count < n && (x - newlimit > 0))
        //        {
        //            x -= newlimit;
        //            Console.Write(" " + x);
        //            count++;

        //        }
        //        x = temp;
        //        while (count <= n)
        //        {
        //            x += newlimit;
        //            Console.Write(" " + x);
        //            count++;
        //        }
        //        Console.WriteLine();
        //    }
        //}
    }
}
