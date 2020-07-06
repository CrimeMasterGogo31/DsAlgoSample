using System;
using System.Collections.Generic;
using System.Text;

namespace DemoConsole.LeetCode
{
    public class Solution173
    {
        public int FindTheCity(int n, int[][] edges, int distanceThreshold)
        {

            Dictionary<int, int[]> dict = new Dictionary<int, int[]>();
            int[,] dis = new int[n, n];
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    dis[i, j] = 10001;
                }
            }
            //Dictionary<int, List<Node>> dict = new Dictionary<int, List<Node>>();

            foreach (var edge in edges)
            {
                if (!dict.ContainsKey(edge[0]))
                {
                    var val = new int[n + 1];
                    val[edge[1]] = edge[2];
                    dict.Add(edge[0], val);
                }
                else
                {
                    dict[edge[0]][edge[1]] = edge[2];
                }
                dis[edge[0], edge[1]] = edge[2];

                if (!dict.ContainsKey(edge[1]))
                {
                    var val = new int[n + 1];
                    val[edge[0]] = edge[2];
                    dict.Add(edge[1], val);
                }
                else
                {
                    dict[edge[1]][edge[0]] = edge[2];
                }

                dis[edge[1], edge[0]] = edge[2];

            }


            for (int k = 0; k < n; k++)
            {
                for (int i = 0; i < n; i++)
                {
                    for (int j = 0; j < n; j++)
                    {
                        dis[i, j] = Math.Min(dis[i, j], dis[i, k] + dis[k, j]);
                    }
                }

            }

            int[] r = new int[n];
            int lowestnum = 10001;
            int city = -1;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (i == j)
                        continue;
                    if (dis[i, j] <= distanceThreshold)
                        r[i]++;
                }
                if (r[i] <= lowestnum)
                {
                    city = i;
                    lowestnum = r[i];
                }
            }
            return city;

           

        }

        
        //public void BFS(Dictionary<int, List<Node>> dict, Dictionary<int, List<Node>> reachable, int node, int t, HashSet<int> visited)
        //{
        //    if (t == 0)
        //        return;

        //    //foreach (var neig in dict[node])
        //    //{
        //    //    if (!visited.Contains(neig.n) && neig.w <= t)
        //    //    {
        //    //        visited.Add(neig.n);
        //    //        if (reachable.ContainsKey(neig))
        //    //        {
        //    //            dict[key].Add(neig);
        //    //        }
        //    //        else
        //    //        {
        //    //            dict.Add(key, neig);
        //    //        }

        //    //        BFS(dict, reachable, neigh.n, t - neigh.w, visited);

        //    //    }

        //    //}

        //}


    }
    //public class Node
    //{
    //    public int n;
    //    public int w;

    //    public Node(int N, int W)
    //    {
    //        this.n = N;
    //        this.w = W;
    //    }


    //}
}
