using System;
using System.Collections.Generic;
using System.Text;

namespace DemoConsole.BZ
{
    class ImplicitGraphMatrixDFS
    {
        static int[,] mat;
        static int r;
        static int c;
        static int val = 1;
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
        //        for (int i = 0; i < r; i++)
        //        {
        //            for (int j = 0; j < c; j++)
        //            {
        //                mat[i, j] = 0;
        //            }

        //        }
        //        //visited = new Stack<Node>();
        //        //visited.Push(new Node(si, sj));
        //        val = 1;
        //        DFS(new Node(si, sj));
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

        private static void DFS(Node node)
        {
            if (node.x >= r || node.x < 0 || node.y >= c || node.y < 0)
            {
                return;
            }
            if (mat[node.x, node.y] != 0)
            {
                return;
            }

            mat[node.x, node.y] = val++;

            for (int i = 0; i < 8; i++)
            {
                DFS(new Node(node.x + dirx[i], node.y + diry[i]));
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
