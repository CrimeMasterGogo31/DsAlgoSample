using System;
using System.Collections.Generic;
using System.Text;

namespace DemoConsole.BZ
{
    class AllPossibleParenthesis
    {
        static List<char> visited = new List<char>();
        //public static void Main(string[] args)
        //{
        //    string s = string.Empty;
        //    while ((s = Console.ReadLine()) != null)
        //    {
        //        int n = Convert.ToInt32(s);
        //        printParanthesis(n, 0, 0, 0);
        //        Console.WriteLine();

        //    }
        //}
        private static void printParanthesis(int n, int pos, int open, int close)
        {
            if (pos == (n * 2))
            {
                foreach (var v in visited)
                    Console.Write(v);
                Console.Write(" ");
            }
            if (open < n)
            {
                visited.Add('(');
                printParanthesis(n, pos + 1, open + 1, close);
                visited.RemoveAt(visited.Count - 1);
            }

            if (open > close)
            {
                visited.Add(')');
                printParanthesis(n, pos + 1, open, close + 1);
                visited.RemoveAt(visited.Count - 1);
            }


        }
    }
}
