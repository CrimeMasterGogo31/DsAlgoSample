using System;
using System.Collections.Generic;
using System.Text;

namespace DemoConsole.BZ.Contest_1
{
    class KnightTourProblem
    {
        static int[,] m;
        static int r;
        static int c;
        static int count = 0;
        static int[] dirx = new int[8] { 2, 2, 1, 1, -1, -1, -2, -2 };
        static int[] diry = new int[8] { -1, 1, -2, 2, -2, 2, -1, 1 };
        //static void Main(String[] args)
        //{
        //    var input = Console.ReadLine().Split(" ");
        //    r = Convert.ToInt32(input[0]);
        //    c = Convert.ToInt32(input[1]);
        //    m = new int[r, c];
        //    for (int i = 0; i < r; i++)
        //    {
        //        for (int j = 0; j < c; j++)
        //        {
        //            m[i, j] = -1;
        //        }
        //    }

        //    var node = new Node(0, 0);
        //    m[0, 0] = 0;

        //    if (!KnightTourDFS(node, 1))
        //    {
        //        Console.WriteLine("Not Possible");
        //    }
        //    else
        //    {
        //        for (int i = 0; i < r; i++)
        //        {
        //            for (int j = 0; j < c; j++)
        //            {
        //                Console.Write(m[i, j] + " ");
        //            }
        //            Console.WriteLine();
        //        }
        //    }
        //}


        private static bool KnightTourDFS(Node node, int value)
        {
            if (value == (r * c))
                return true;
            if (r == 1 || c == 1)
                return false;

            for (int i = 0; i < 8; i++)
            {
                int nextx = node.x + dirx[i];
                int nexty = node.y + diry[i];
                if (nextx >= 0 && nextx < r && nexty >= 0 && nexty < c&& m[nextx, nexty]==-1)
                {
                    m[nextx, nexty] = value;
                    if (KnightTourDFS(new Node(nextx, nexty), value + 1))
                    {
                        return true;
                    }
                    else
                    {
                        m[nextx, nexty] = -1;
                    }
                }
            }
            return false;
        }
    }


    //class demo2
    //{
    //    static int row = 0, column = 0;
    //    static void Main(String[] args)
    //    {
    //        string s = Console.ReadLine();



    //        string[] array = s.Split(' ').ToArray();

    //        int r = Convert.ToInt32(array[0]);
    //        row = r;

    //        int c = Convert.ToInt32(array[1]);
    //        column = c;
    //        int[,] mat = new int[r, c];
    //        for (int x = 0; x < r; x++)
    //            for (int y = 0; y < c; y++)
    //                mat[x, y] = -1;




    //        mat[0, 0] = 0;
    //        if (!CheckMoves(mat, 1, 0, 0))
    //        {
    //            Console.Write("Not Possible");
    //        }
    //        else
    //        {

    //            for (int i = 0; i < row; i++)
    //            {
    //                for (int j = 0; j < column; j++)
    //                    Console.Write(mat[i, j] + " ");
    //                Console.WriteLine();
    //            }

    //        }
    //    }



    //    static bool CheckMoves(int[,] mat, int val, int x, int y)
    //    {
    //        int[] xMove = { 2, 2, 1, 1, -1, -1, -2, -2 };
    //        int[] yMove = { -1, 1, -2, 2, -2, 2, -1, 1 };
    //        int xval, yval;



    //        if (row == 1 || column == 1)
    //        {
    //            return false;
    //        }
    //        if (val == (row * column))
    //        {
    //            return true;
    //        }
    //        for (int i = 0; i < 8; i++)
    //        {
    //            xval = x + xMove[i];
    //            yval = y + yMove[i];
    //            if (xval >= 0 && xval < row && yval >= 0 && yval < column && mat[xval, yval] == -1)
    //            {
    //                mat[xval, yval] = val;
    //                if (CheckMoves(mat, val + 1, xval, yval))
    //                    return true;
    //                else
    //                    mat[xval, yval] = -1;
    //            }
    //        }
    //        return false;



    //    }
    //}
}
