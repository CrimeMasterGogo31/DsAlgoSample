using System;
using System.Collections.Generic;
using System.Text;

namespace DemoConsole.BZ
{
    class DFSInExplicitGraph
    {
        bool[] visited;
        IDictionary<int, List<int>> d;
        void dfsWithVertex(IDictionary<int, List<int>> g, int s)
        {
            d = g;
            visited = new bool[g.Count + 1];
            DFS(s);
        }

        private void DFS(int s)
        {
            if (visited[s])
                return;
            Console.Write(s + " ");
            visited[s] = true;

            foreach (var item in d[s])
            {
                DFS(item);
            }

        }
    }
}
