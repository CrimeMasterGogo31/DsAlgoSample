using System;
using System.Collections.Generic;
using System.Text;

namespace DemoConsole.BZ.Contest_1
{
    class RatInMaze
    {
        static int[,] m;
        static int r;
        static int c;
        static List<Node> visitedPath;
        static bool pathFound;

        //static void Main(String[] args)
        //{
        //    visitedPath = new List<Node>();
        //    var input = Console.ReadLine().Split(" ");
        //    r = Convert.ToInt32(input[0]);
        //    c = Convert.ToInt32(input[1]);
        //    m = new int[r, c];
        //    for (int i = 0; i < r; i++)
        //    {
        //        var rows = Array.ConvertAll(Console.ReadLine().Trim().Split(' '), wTemp => Convert.ToInt32(wTemp));
        //        for (int j = 0; j < c; j++)
        //        {
        //            m[i, j] = rows[j];
        //        }
        //    }

        //    var node = new Node(0, 0);
        //    visitedPath.Add(node);
        //    FindPathDFS(node);
        //    if (!pathFound)
        //    {
        //        Console.WriteLine("Not Possible");
        //    }

        //}

        private static void FindPathDFS(Node node)
        {
            if (node.x >= r || node.y >= c)
            {
                return;
            }
            if (m[node.x, node.y] == 0)
            {
                return;
            }
            if (node.x == r - 1 && node.y >= c - 1)
            {
                PopulateMat();
                pathFound = true;
                return;
            }

            var down = new Node(node.x + 1, node.y);
            visitedPath.Add(down);
            FindPathDFS(down);
            visitedPath.Remove(down);
            if (pathFound)
                return;
            var right = new Node(node.x, node.y + 1);
            visitedPath.Add(right);
            FindPathDFS(right);
            visitedPath.Remove(right);
        }

        private static void PopulateMat()
        {
            m = new int[r, c];
            foreach (var n in visitedPath)
            {
                m[n.x, n.y] = 1;
            }

            for (int i = 0; i < r; i++)
            {
                for (int j = 0; j < c; j++)
                {
                    Console.Write(m[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
    public class Node
    {
        public Node(int X, int Y)
        {
            x = X;
            y = Y;
        }
        public int x;
        public int y;
    }
}
