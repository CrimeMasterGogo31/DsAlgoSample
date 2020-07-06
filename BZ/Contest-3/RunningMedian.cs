using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace DemoConsole.BZ.Contest_3
{
    class RunningMedian
    {
        static double[] runningMedian(int[] a)
        {
            var res = new double[a.Length];

            if (a.Length == 1)
            {
                res[0] = a[0];
                return res;
            }
            var sl = new List<double>();

            for (int i = 0; i < a.Length; i++)
            {
                double m;
                sl.Add(a[i]);
                var sa = sl.ToArray();
                Array.Sort(sa);
                if (sa.Length % 2 == 0)
                {
                    m = (sa[(sa.Length / 2) - 1] + sa[(sa.Length / 2)]) / 2;
                }
                else
                {
                    m = sa[(sa.Length / 2)];
                }
                res[i] = m;
            }
            return res;
        }

        //static void Main(string[] args)
        //{
        //    // TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        //    int aCount = Convert.ToInt32(Console.ReadLine());

        //    int[] a = new int[aCount];

        //    for (int aItr = 0; aItr < aCount; aItr++)
        //    {
        //        int aItem = Convert.ToInt32(Console.ReadLine());
        //        a[aItr] = aItem;
        //    }

        //    double[] result = runningMedian(a);

        //    foreach (var ele in result)
        //    {
        //        Console.WriteLine(ele.ToString("#.0"));
        //    }
        //    //textWriter.Flush();
        //    //textWriter.Close();
        //}

    }
}
