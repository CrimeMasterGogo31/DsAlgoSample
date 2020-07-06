using System;
using System.Collections.Generic;
using System.Text;

namespace DemoConsole
{
    public class ParenthesisMatching
    {
        public bool CheckValidString(string s)
        {

            if (s == null || s == "" || s == "*")
                return true;
            if (s.Length == 1 && (s == "(" || s == ")"))
                return false;
            var arr = s.ToCharArray();
            return validate(0, arr, new Stack<char>());

        }

        bool validate(int ind, char[] arr, Stack<char> stack)
        {
            if (ind == arr.Length)
                return stack.Count == 0;

            var c = arr[ind];
            if (c == '(')
            {
                stack.Push(c);
            }
            else if (c == ')')
            {
                if (stack.Count == 0)
                    return false;
                stack.Pop();
            }
            else if (c == '*')
            {

                stack.Push('(');
                if (validate(ind + 1, arr, stack))
                {
                    return true;
                }
                stack.Pop();
                if (stack.Count == 0)
                    return false;
                stack.Pop();
                if (validate(ind + 1, arr, stack))
                    return true;

                return validate(ind + 1, arr, stack);
            }

            if (ind == arr.Length - 1)
                return stack.Count == 0;

            return validate(ind+1, arr, stack);
        }
    }
}
