using System;
using System.Collections.Generic;
using System.Text;

namespace DemoConsole.HackerRank
{
    class PathExistenceInGraph
    {
        static int[] parent;
        //public static void Main()
        //{
        //    string[] input = Console.ReadLine().Split(' ');
        //    int[] nums = Array.ConvertAll(input, Int32.Parse);
        //    int size = nums[0];
        //    int query = nums[1];
        //    parent = new int[size + 1];
        //    while (query != 0)
        //    {
        //        var line = Array.ConvertAll(Console.ReadLine().Split(' '), Int32.Parse);
        //        if (line[0] == 1)
        //        {
        //            AddNode(line[1], line[2]);
        //        }
        //        else
        //        {
        //            query--;
        //            Console.WriteLine(FindParent(line[1]) == FindParent(line[2]) ? "Yes" : "No");
        //        }

        //    }
        //}

        private static void AddNode(int u, int v)
        {

            if (parent[u] == 0 && parent[v] == 0)
            {
                parent[u] = parent[v] = u;
            }
            else if (parent[u] == 0)
            {
                parent[u] = parent[v];
            }
            else {
                parent[v] = parent[u];
            }
        }

        static int FindParent(int i)
        {
            if (parent[i] == i)
                return i;
            else
                return parent[i] = FindParent(parent[i]);
        }
    }
}
