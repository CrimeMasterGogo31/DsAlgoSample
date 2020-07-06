using System;
using System.Collections.Generic;
using System.Text;

namespace DemoConsole.BZ
{
    class ImplicitGraphMatrixBFS
    {
        static int[,] mat;
        static Queue<Node> visited;
        static int r;
        static int c;
        //public static void Main(string[] args)
        //{
        //    int t = ReadInteger();
        //    while (t-- != 0)
        //    {
        //        var input = Console.ReadLine().Split(" ");
        //        r = Convert.ToInt32(input[0]);
        //        c = Convert.ToInt32(input[1]);
        //        mat = new int[r, c];
        //        int si = Convert.ToInt32(input[2]);
        //        int sj = Convert.ToInt32(input[3]);
        //        int val = 1;
        //        for (int i = 0; i < r; i++)
        //        {
        //            for (int j = 0; j < c; j++)
        //            {
        //                mat[i, j] = 0;
        //            }

        //        }
        //        visited = new Queue<Node>();
        //        visited.Enqueue(new Node(si, sj));
        //        BFS(new Node(si, sj), val);
        //        for (int i = 0; i < r; i++)
        //        {
        //            for (int j = 0; j < c; j++)
        //            {
        //                Console.Write(mat[i, j] + " ");
        //            }
        //            Console.WriteLine();
        //        }
        //        Console.WriteLine();

        //    }
        //}



        private static void BFS(Node node, int val)
        {
            mat[node.x, node.y] = val++;
            while (visited.Count != 0)
            {
                var cur = visited.Dequeue();
                for (int i = 0; i < 8; i++)
                {
                    if (cur.x + dirx[i] >= r || cur.x + dirx[i] < 0 || cur.y + diry[i] >= c || cur.y + diry[i] < 0)
                        continue;
                    if ((mat[cur.x + dirx[i], cur.y + diry[i]] != 0))
                        continue;
                    visited.Enqueue(new Node(cur.x + dirx[i], cur.y + diry[i]));
                    mat[cur.x + dirx[i], cur.y + diry[i]] = val++;
                }
            }
            return;
        }

        static int ReadInteger()
        {
            return Convert.ToInt32(Console.ReadLine());
        }

        static int[] dirx = new int[8] { -1, -1, 0, +1, +1, +1, 0, -1, };
        static int[] diry = new int[8] { 0, +1, +1, +1, 0, -1, -1, -1 };

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
}
