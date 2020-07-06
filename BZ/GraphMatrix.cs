using System;
using System.Collections.Generic;
using System.Text;

namespace DemoConsole.BeingZero
{
    class GraphMatrix
    {
        //public static void Main(string[] args)
        //{
        //    int t = ReadInteger();

        //    var input = Console.ReadLine().Split(" ");
        //    int r = Convert.ToInt32(input[0]);
        //    int c = Convert.ToInt32(input[0]);
        //    int[,] mat = new int[r, c];
        //    int si = Convert.ToInt32(input[0]);
        //    int sj = Convert.ToInt32(input[0]);
        //    int val = 1;
        //    for (int i = 0; i < r; i++)
        //    {
        //        for (int j = 0; j < c; j++)
        //        {
        //            mat[i, j] = 0;
        //        }

        //    }
        //    Stack<Node> visited = new Stack<Node>();
        //    visited.Push(new Node(si, sj));

        //}
        static int ReadInteger()
        {
            return Convert.ToInt32(Console.ReadLine());
        }

        static int[] dir = new int[] { -1, 0 , -1, +1 , 0, +1 , +1, +1 , +1, 0 , +1, -1 , 0, -1 , -1, -1  };

    }
    public class Node
    {
        public Node(int _r, int _c)
        {
            r = _r;
            c = _c;
        }
        int r;
        int c;
    }
}
