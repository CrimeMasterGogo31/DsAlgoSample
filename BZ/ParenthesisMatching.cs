using System;
using System.Collections.Generic;
using System.Text;

namespace DemoConsole.BZ
{
    class ParenthesisMatching
    {
        bool IsValidExpression(string s)
        {

            Stack<char> stack = new Stack<char>();
            foreach (var c in s)
            {
                if ((c == '(') || c == '{' || c == '[' || (c == ')') || c == '}' || c == ']')
                {
                    if (stack.Count != 0 && c == ')' && stack.Peek() == '(')
                    {
                        stack.Pop();
                    }
                    else if (stack.Count != 0 && c == '}' && stack.Peek() == '{')
                    {
                        stack.Pop();
                    }
                    else if (stack.Count != 0 && c == ']' && stack.Peek() == '[')
                    {
                        stack.Pop();
                    }
                    else
                    {
                        stack.Push(c);
                    }


                }
            }
            if (stack.Count == 0)
                return true;
            else
                return false;
        }
    }
}
