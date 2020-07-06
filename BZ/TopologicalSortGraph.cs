using System;
using System.Collections.Generic;
using System.Text;

namespace DemoConsole.BZ
{
    class TopologicalSortGraph
    {
        Stack<int> ss;
        bool[] visited;
        Dictionary<int, List<int>> d;
        internal void topSort(Dictionary<int, List<int>> g)
        {
            d = g;
            ss = new Stack<int>();
            visited = new bool[g.Count + 1];

            foreach (var key in g.Keys)
            {
                SortHelper(key);
            }

            while (ss.Count > 0)
            {
                Console.Write(ss.Pop() + " ");
            }
            Console.WriteLine();
        }

        private void SortHelper(int v)
        {
            if (visited[v])
            {
                return;
            }
            visited[v] = true;
            foreach (var k in d[v])
            {
                SortHelper(k);

            }
            ss.Push(v);
        }
    }
}
