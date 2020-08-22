using System;
using System.Collections.Generic;
using System.Text;

namespace DemoConsole.LeetCode
{
    public class AllPathFromSourceToTargetClass
    {
        public IList<IList<int>> AllPathsSourceTarget(int[][] graph)
        {
            var result = new List<IList<int>>();
            if (graph.Length == 0 || graph[0].Length == 0 || graph[0].Length == 1)
            {
                result.Add(new List<int>() { 0 });
                return result;
            }

            var n = graph.Length - 1;

            foreach (var neighbour in graph[0])
            {
                DFSTraversal(neighbour, new List<int>() { 0 }, n, result, graph);
            }
            return result;
        }
        //[[4,3,1],[3,2,4],[3],[4],[]]
        void DFSTraversal(int neighbour, List<int> curr, int n, List<IList<int>> result, int[][] graph)
        {
            curr.Add(neighbour);

            if (neighbour == n)
            {
                result.Add(curr);
                curr.RemoveAt(curr.Count - 1);
                return;
            }

            foreach (var neigh in graph[neighbour])
            {
                DFSTraversal(neigh, curr, n, result, graph);
                curr.RemoveAt(curr.Count - 1);
            }

        }
    }
}
