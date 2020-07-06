using System;
using System.Collections.Generic;
using System.Text;

namespace DemoConsole.LeetCode
{
    public class BackSpaceStringCompare
    {
        public bool BackspaceCompare(string S, string T)
        {
            var stackS = new Stack<char>();
            var stackT = new Stack<char>();

            foreach (var c in S)
            {
                if (c == '#')
                {
                    if (stackS.Count > 0)
                        stackS.Pop();
                    continue;
                }
                stackS.Push(c);
            }

            foreach (var c in T)
            {
                if (c == '#')
                {
                    if (stackT.Count > 0)
                        stackT.Pop();
                    continue;
                }

                stackT.Push(c);
            }

            if (stackT.Count == 0 && stackS.Count == 0)
                return true;

            while (stackT.Count > 0 && stackS.Count > 0)
            {
                var s = stackT.Pop();
                var t = stackS.Pop();
                if (s != t)
                    return false;
            }
            if (stackT.Count > 0 || stackS.Count > 0)
                return false;

            return true;
        }
    }
}
