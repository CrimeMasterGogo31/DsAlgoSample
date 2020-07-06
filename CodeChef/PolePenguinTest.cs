using System;
using System.Collections.Generic;
using System.Text;

namespace DemoConsole.CodeChef
{

    public class PolePenguinTest
    {
        //public static void Main()
        //{
        //    int t = Convert.ToInt32(Console.ReadLine().Trim());
        //    while (t-- != 0)
        //    {
        //        var arr = Array.ConvertAll(Console.ReadLine().Trim().Split(' '),
        //             tmp => Convert.ToInt32(tmp));
        //        var c = arr[0];
        //        var time = arr[1];
        //        var m = new int[c, 3];
        //        for (int i = 0; i < c; i++)
        //        {
        //            var rows = Array.ConvertAll(Console.ReadLine().Trim().Split(' '), wTemp => Convert.ToInt32(wTemp));
        //            for (int j = 0; j < 3; j++)
        //            {
        //                m[i, j] = rows[j];
        //            }
        //        }

        //        var res = BT(m, 0, c, time, 0);
        //        Console.WriteLine(res);

        //    }
        //}
        private static int BT(int[,] m, int r, int c, int time, int total)
        {
            if (time <= 0)
                return 0;
            if (r >= c)
                return 0;
            if (time < m[r, 2])
                return BT(m, r + 1, c, time, total);

            return total + Math.Max(BT(m, r + 1, c, time - m[r, 2], total + m[r, 0] * m[r, 1]),
            BT(m, r + 1, c, time, total));

        }
    }

}
