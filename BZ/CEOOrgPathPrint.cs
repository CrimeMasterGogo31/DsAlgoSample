using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DemoConsole.BeingZero.CEO
{
    class BeingZero
    {
        IDictionary<int, List<int>> orgChart;
        List<int> currentPath;
        HashSet<int> explore = new HashSet<int>();

        public BeingZero(IDictionary<int, List<int>> oc, List<int> cp)
        {
            orgChart = oc;
            currentPath = cp;
        }


        public void generateAllPaths(int empId)
        {
            if (!orgChart.ContainsKey(empId))
            {
                PrintCurrentPath();
                currentPath.Remove(empId);
                return;
            }

            while (currentPath.Count > 0)
            {
                foreach (var val in orgChart[empId])
                {
                    if (!explore.Contains(val))
                    {
                        currentPath.Add(val);
                        generateAllPaths(val);
                        explore.Add(val);
                    }
                }
                currentPath.Remove(empId);
                return;
            }
        }

        private void PrintCurrentPath()
        {
            foreach (var p in currentPath)
            {
                Console.Write(p + " ");
            }
            Console.WriteLine();
        }
    }


    class Test
    {
        //public static void Main(string[] args)
        //{
        //    int t = ReadLineAsInt();
        //    while (t-- != 0)
        //    {
        //        int[] nceoid = ReadLineAsIntArray();
        //        int n = nceoid[0];
        //        int ceoid = nceoid[1];
        //        IDictionary<int, List<int>> orgChart = new Dictionary<int, List<int>>();
        //        if (n != 0)
        //        {
        //            for (int i = 0; i < n; i++)
        //            {
        //                int[] mgrReportee = ReadLineAsIntArray();
        //                if (!orgChart.ContainsKey(mgrReportee[0]))
        //                {
        //                    orgChart.Add(mgrReportee[0], new List<int>());
        //                }
        //                orgChart[mgrReportee[0]].Add(mgrReportee[1]);
        //            }
        //        }
        //        List<int> curPath = new List<int>();
        //        curPath.Add(ceoid);
        //        BeingZero bz = new BeingZero(orgChart, curPath);
        //        bz.generateAllPaths(ceoid);
        //        Console.WriteLine();
        //    }
        //}
        static int ReadLineAsInt()
        {
            return Convert.ToInt32(Console.ReadLine().Trim());
        }

        static int[] ReadLineAsIntArray()
        {
            return Array.ConvertAll(Console.ReadLine().Trim().Split(' '), wTemp => Convert.ToInt32(wTemp));
        }

        static List<int> ReadLineAsIntList()
        {
            int[] a = ReadLineAsIntArray();
            return a.OfType<int>().ToList();
        }
    }
}
