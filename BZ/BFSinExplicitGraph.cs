using System;
using System.Collections.Generic;
using System.Text;

namespace DemoConsole.BZ
{
    class BFSinExplicitGraph
    {
        IDictionary<int, List<int>> d;
        bool[] visited;
        Queue<int> q;
        void bfs(IDictionary<int, List<int>> g, int s)
        {
            d = g;
            q = new Queue<int>();
            visited = new bool[g.Count + 1];

            q.Enqueue(s);
            visited[s] = true;
           // Console.Write(s + " ");

            while (q.Count > 0)
            {
                var cur = q.Dequeue();
                Console.Write(cur + " ");

                foreach (var item in d[cur])
                {
                    if (visited[item])
                        continue;
                    q.Enqueue(item);
                    visited[item] = true;
                }
            }
        }
    }
}
