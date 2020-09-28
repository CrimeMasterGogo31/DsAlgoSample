using System;
using System.Collections.Generic;
using System.Text;

namespace DemoConsole.GFG
{
    public class SortStack
    {
        public Stack<int> Sort (Stack<int> stack)
        {
            var res = new Stack<int>();
            while(stack.Count >0 )
            {
                var cur = stack.Pop();
                if(res.Count ==0 || res.Peek() < cur)
                    res.Push(cur);
                else
                {
                    while(res.Count > 0 && res.Peek() > cur)
                    {
                        stack.Push(res.Pop());
                    }
                    res.Push(cur);
                }
            }
            return res;
        }
    }
}