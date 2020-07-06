using System;
using System.Collections.Generic;
using System.Text;

namespace DemoConsole.BZ
{
    class CycleDetectionInUndirectedGraph
    {
        static bool[] visited;
        static bool isCycleFound;
        static Dictionary<int, List<int>> d;
        //public static void Main(string[] args)
        //{
        //    int t = Convert.ToInt32(Console.ReadLine().Trim());
        //    while (t-- != 0)
        //    {
        //        string[] vedw = Console.ReadLine().Trim().Split(' ');
        //        int nv = Convert.ToInt32(vedw[0]);
        //        int ne = Convert.ToInt32(vedw[1]);

        //        d = new Dictionary<int, List<int>>();

        //        while (ne-- != 0)
        //        {
        //            string[] line = Console.ReadLine().Trim().Split(' ');
        //            int n1 = Convert.ToInt32(line[0]);
        //            int n2 = Convert.ToInt32(line[1]);

        //            if (d.ContainsKey(n1))
        //            {
        //                d[n1].Add(n2);
        //            }
        //            else
        //            {
        //                d.Add(n1, new List<int>() { n2 });
        //            }

        //            if (d.ContainsKey(n2))
        //            {
        //                d[n2].Add(n1);
        //            }
        //            else
        //            {
        //                d.Add(n2, new List<int>() { n1 });
        //            }
        //        }
        //        visited = new bool[d.Keys.Count + 1];

        //        foreach (var i in d.Keys)
        //        {
        //            if (!isCycleFound)
        //                break;
        //            IsCycleUsingDFS(i, i);
        //        }
        //        Console.WriteLine(isCycleFound.ToString().ToLower());
        //    }
        //}

        private static void IsCycleUsingDFS(int item, int p)
        {
            if (visited[item])
            {
                isCycleFound = true;
                return;
            }
            visited[item] = true;

            foreach (var i in d[item])
            {
                if (!isCycleFound)
                    return;
                if (item != p)
                    IsCycleUsingDFS(i, item);
            }
        }
    }
}
