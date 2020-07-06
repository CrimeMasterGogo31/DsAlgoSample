using System;
using System.Collections.Generic;
using System.Text;

namespace DemoConsole.BZ
{
    class SingleSourceSortestPathUndirectedGraph
    {
        static bool pathFound = false;
        static bool[] visited;
        static int minpath;

        //public static void Main(string[] args)
        //{
        //    int t = Convert.ToInt32(Console.ReadLine().Trim());
        //    while (t-- != 0)
        //    {
        //        string[] vedw = Console.ReadLine().Trim().Split(' ');
        //        int nv = Convert.ToInt32(vedw[0]);
        //        int ne = Convert.ToInt32(vedw[1]);

        //        Dictionary<int, List<int>> d = new Dictionary<int, List<int>>();

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
        //        int qe = Convert.ToInt32(Console.ReadLine().Trim());

        //        string[] quesries = Console.ReadLine().Trim().Split(' ');
        //        foreach (var q in quesries)
        //        {
        //            FindShortestPath(d, Convert.ToInt32(q));
        //        }

        //    }
        //}

        private static void FindShortestPath(Dictionary<int, List<int>> d, int v)
        {
            for (int i = 0; i < d.Count; i++)
            {
                minpath = int.MaxValue;
                //pathFound = false;
                visited = new bool[d.Count + 1];
                Helper(d, i, v, 0);
                Console.Write(minpath + " ");
            }
        }

        private static void Helper(Dictionary<int, List<int>> dict, int s, int d, int count)
        {

            if (s == d)
            {

                if (minpath > count)
                {
                    minpath = count;
                }
                return;
            }

            foreach (var node in dict[s])
            {
                if (!visited[node])
                {
                    visited[node] = true;
                    Helper(dict, node, d, count + 1);
                    visited[node] = true;
                }
            }
            return;

            //if (key == v)
            //{
            //    visited[key] = true;
            //    //pathFound = true;
            //    if (count < minpath)
            //        minpath = count;
            //    return;
            //}

            //foreach (var node in d[key])
            //{

            //    if (!visited[node])
            //    {
            //        visited[node] = true;
            //        Helper(d, node, v, count + 1);
            //    }
            //}
            //return;
        }
    }
}
