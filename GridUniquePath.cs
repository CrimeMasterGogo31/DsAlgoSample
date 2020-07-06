using System;
using System.Collections.Generic;
using System.Text;

namespace DemoConsole
{
    public class GridUniquePath
    {


        int row;
        int column;
        List<int> rowNums = new List<int>() { 0, -1, 0, 1 };
        List<int> colNums = new List<int>() { -1, 0, 1, 0 };
        public int uniquePaths(int A, int B)
        {
            row = A;
            column = B;
            var source = new node(0, 0);
            var dest = new node(A - 1, B - 1);
            int res = BFS(source, dest);

            return res;
        }

        private int BFS(node source, node dest)
        {
            int count = 0;
            if (source.x == dest.x && source.y == dest.y)
                return 1;
            Stack<node> stack = new Stack<node>();
            stack.Push(source);

            while (stack.Count > 0)
            {
                var temp = stack.Peek();
                
                //go right
                var rightNode = new node(temp.x, temp.y + 1);
                if (IsTraverable(rightNode))
                {
                    if (rightNode.x == dest.x && rightNode.y == dest.y)
                    {
                        count++;
                        stack.Pop();
                    }
                    else
                    {
                        stack.Push(rightNode);
                    }
                }

                //go down 
                var downNode = new node(temp.x + 1, temp.y);
                if (IsTraverable(downNode))
                {
                    if (downNode.x == dest.x && downNode.y == dest.y)
                    {
                        count++;
                        stack.Pop();
                    }
                    else
                    {
                        stack.Push(downNode);
                    }
                }

            }


            return count;
        }

        private bool IsTraverable(node node)
        {
            if (node.x >= row || node.y >= column)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        class node
        {
            public int x;
            public int y;
            public node(int X, int Y)
            {
                this.x = X;
                this.y = Y;
            }
        }
    }
}
