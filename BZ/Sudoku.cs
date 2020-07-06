using System;
using System.Collections.Generic;
using System.Text;

namespace DemoConsole.BZ
{
    public class Sudoku
    {
        static int[,] m;
        static List<node> UnfilledNodes;
        static bool solved = false;
        //public static void Main(string[] args)
        //{
        //    int t = Convert.ToInt32(Console.ReadLine());
        //    while (t-- != 0)
        //    {
        //        UnfilledNodes = new List<node>();
        //        solved = false;
        //        m = new int[9, 9];
        //        Console.ReadLine();
        //        for (int i = 0; i < 9; i++)
        //        {
        //            var rows = ReadLineAsIntArray();
        //            for (int j = 0; j < 9; j++)
        //            {
        //                m[i, j] = rows[j];
        //            }
        //        }
        //        SolveSudoku(m);
        //    }
        //}
        
        private static void SolveSudoku(int[,] m)
        {
            UnfilledNodes = GetUnFilledNodes(m);
            Solve(0);

        }

        private static void Solve(int cellIdx)
        {
            if (cellIdx == UnfilledNodes.Count)
            {
                for (int i = 0; i < 9; i++)
                {
                    for (int j = 0; j < 9; j++)
                    {
                        Console.Write(m[i, j] + " ");
                    }
                    Console.WriteLine();
                }
                Console.WriteLine();
                solved = true;
                return;
            }
            var choiceList = GetChoiceForNode(UnfilledNodes[cellIdx]);

            if (choiceList.Count == 0)
                return;

            foreach (var choice in choiceList)
            {
                var cell = UnfilledNodes[cellIdx];
                m[cell.r, cell.c] = choice;
                Solve(cellIdx + 1);
                if (solved)
                    return;
                m[cell.r, cell.c] = 0;
            }
        }

        private static List<int> GetChoiceForNode(node node)
        {
            List<int> choices = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            var row = node.r;
            var col = node.c;
            for (int i = 0; i < 9; i++)
            {
                if ((m[row, i] != 0) && choices.Contains(m[row, i]))
                {
                    choices.Remove(m[row, i]);
                }
                if ((m[i, col] != 0) && choices.Contains(m[i, col]))
                {
                    choices.Remove(m[i, col]);
                }
            }
            int rowcell = row / 3;
            int colcell = col / 3;

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if ((m[(rowcell * 3) + i, (colcell * 3) + j] != 0) && (choices.Contains(m[(rowcell * 3) + i, (colcell * 3) + j])))
                    {

                        choices.Remove(m[(rowcell * 3) + i, (colcell * 3) + j]);
                    }
                }
            }
            return choices;
        }

        private static List<node> GetUnFilledNodes(int[,] m)
        {
            var list = new List<node>();
            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    if (m[i, j] == 0)
                    {
                        list.Add(new node(i, j));
                    }
                }
            }
            return list;
        }

        static int[] ReadLineAsIntArray()
        {
            return Array.ConvertAll(Console.ReadLine().Trim().Split(' '), wTemp => Convert.ToInt32(wTemp));
        }
    }
    class node
    {
        public node(int x, int y)
        {
            r = x;
            c = y;
        }

        public int r;
        public int c;
    }
}
