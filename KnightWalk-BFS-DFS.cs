using System;
using System.Collections.Generic;
using System.Text;

namespace DemoConsole
{
    #region Question-Google
    //    Given a chess board of order N x M and source points(s1, s2) and destination points(d1, d2). The task to find minimum number of moves required by the Knight to go to the destination cell.

    //Input:
    //The first line of input contains an integer T denoting the number of testcases. Then T test cases follow.Each test case contains two lines.The first line of each testcase contains two space separated integers N and M. Then in the next line are four space separated values s1, s2 and d1, d2.

    //Output:
    //For each testcase in a new line print the minimum number of moves required by the knight to go to the destination from the source.If no such move is possible print -1.

    //Constraints:
    //1 <= T <= 100
    //1 <= N, M <= 25

    //Example:
    //Input:
    //2
    //4 7
    //2 6 2 4
    //7 13
    //2 8 3 4

    //Output:
    //2
    //3 
    #endregion 
    public class KnightWalk_BFS_DFS
    {
        int[,] board;
        int[,] moves = new int[8, 2] { { 1, 2 }, { 2, 1 }, { 2, -1 }, { 1, -2 }, { -1, -2 }, { -2, -1 }, { -2, 1 }, { -1, 2 } };
        int _row;
        int _col;
        int distance = 0;

        public void IntiateBoard(int row, int col)
        {
            board = new int[row, col];
            _row = row;
            _col = col;
        }

        //public int CalculateMove(int s1, int s2, int d1, int d2)
        //{
        //    Stack<Node> visitedNode = new Stack<Node>();
        //    var start = new Node(s1, s2);

        //    visitedNode.Push(start);

        //    while (visitedNode.TryPeek(out Node x))
        //    {

        //        ApplyMovement(visitedNode);

        //    }


        //    return 0;
        //}

        //private void ApplyMovement(Stack<Node> visitedNode)
        //{
        //    foreach (var move in moves) {


        //    }

        //}

        private bool validateMove(int r, int c)
        {
            if (r < 1 || r > _row)
                return false;
            if (c < 1 || c > _col)
                return false;
            return true;
        }

    }

    //public class Node
    //{
    //    public Node(int X, int Y)
    //    {
    //        x = X;
    //        y = Y;
    //    }

    //    int x;
    //    int y;
    //}
}
