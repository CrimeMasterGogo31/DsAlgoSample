using System;
using System.Collections.Generic;
using System.Text;

namespace DemoConsole.BZ
{
    public class CompareInterval : IComparer<Interval>
    {
        public int Compare(Interval x, Interval y)
        {
            return x.s - y.s;
        }
    }
    public class Interval
    {
        public int s;
        public int e;
        public Interval(int S, int E)
        {
            s = S;
            e = E;
        }
    }
    public class MeetingRoomScheduling
    {
        public void Schedule()
        {
            var t = Convert.ToInt32(Console.ReadLine());
            while (t-- != 0)
            {
                var n = Convert.ToInt32(Console.ReadLine());
                if (n == 0)
                {
                    Console.WriteLine(0);
                    continue;
                }

                var arr = new int[n][];
                int counter = 0;
                while (counter < n)
                {
                    var sch = Array.ConvertAll(Console.ReadLine().Trim().Split(' '), tmp => Convert.ToInt32(tmp));

                    arr[counter++] = sch;
                }
                Array.Sort(arr, (x, y) =>
                {
                    if (x[0] == y[0])
                        return x[1] - y[1];
                    else
                        return x[0] - y[0];
                });
                var res = new List<int[]>();
                res.Add(arr[0]);
                for (int i = 1; i < n; i++)
                {
                    var top = res[res.Count - 1];
                    if (top[1] <= arr[i][0])
                        res.Add(arr[i]);
                    if (top[1] < arr[i][1])
                    {
                        continue;
                    }
                    else
                    {
                        res.RemoveAt(res.Count - 1);
                        res.Add(arr[i]);
                    }
                }
                Console.WriteLine(res.Count);
            }
        }

        //public static void Main()
        //{

        //    int t = Convert.ToInt32(Console.ReadLine());
        //    while (t-- != 0)
        //    {
        //        int n = Convert.ToInt32(Console.ReadLine());
        //        Interval[] arr = new Interval[n];
        //        for (int i = 0; i < n; i++)
        //        {
        //            var input = Console.ReadLine().Split(" ");
        //            var s = Convert.ToInt32(input[0]);
        //            var e = Convert.ToInt32(input[1]);
        //            arr[i] = new Interval(s, e);
        //        }
        //        var cmp = new CompareInterval();
        //        Array.Sort(arr, cmp);
        //        int total = 0;
        //        var curStart = arr[0].s;
        //        var curEnd = arr[0].e;
        //        List<Interval> tobeAttended = new List<Interval>();
        //        for (int i = 0; i < n - 1; i++)
        //        {
        //            var next = arr[i + 1];
        //            if (curEnd > next.s)
        //            {
        //                curEnd = Math.Min(curEnd, next.e);

        //                continue;
        //            }
        //            tobeAttended.Add(new Interval(curStart, curEnd));
        //            curStart = next.s;
        //            curEnd = next.e;
        //            total++;
        //        }

        //    }
        //}
    }
}
