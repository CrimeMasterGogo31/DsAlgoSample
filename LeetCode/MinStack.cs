using System;
using System.Collections.Generic;
using System.Text;

namespace DemoConsole.LeetCode
{
    public class stackNode
    {
        public int val;
        public int min;
        public stackNode(int x, int y)
        {
            val = x;
            min = y;
        }
    }

    public class MinStack
    {
        int count;
        Stack<stackNode> stack;
        /** initialize your data structure here. */
        public MinStack()
        {
            stack = new Stack<stackNode>();
            count = 0;
        }

        public void Push(int x)
        {
            if (count == 0)
                stack.Push(new stackNode(x, x));
            else
            {
                var t = stack.Peek().min;
                var min = t < x ? t : x;
                stack.Push(new stackNode (x, min));
            }
            count++;
        }

        public void Pop()
        {
            if (count > 0)
            {
                stack.Pop();
                count--;
            }
        }

        public int Top()
        {
            return stack.Peek().val;
        }

        public int GetMin()
        {
            return stack.Peek().min;

        }
    }
}
