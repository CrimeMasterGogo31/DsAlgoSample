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
