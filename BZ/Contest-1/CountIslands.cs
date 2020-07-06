using System;
using System.Collections.Generic;
using System.Text;

namespace DemoConsole.BZ.Contest_1
{
    class CountIslands
    {
        static char[,] m;
        static int r;
        static int c;
        static char count = '0';
        //static void Main(String[] args)
        //{
        //    var input = Console.ReadLine().Split(" ");
        //    r = Convert.ToInt32(input[0]);
        //    c = Convert.ToInt32(input[1]);
        //    m = new char[r, c];
        //    for (int i = 0; i < r; i++)
        //    {
        //        var rows = Array.ConvertAll(Console.ReadLine().Trim().Split(' '), wTemp => Convert.ToChar(wTemp));
        //        for (int j = 0; j < c; j++)
        //        {
        //            m[i, j] = rows[j];
        //        }
        //    }

        //    for (int i = 0; i < r; i++)
        //    {
        //        for (int j = 0; j < c; j++)
        //        {
        //            if (m[i, j] == 'X')
        //                FloodFill(i, j, ++count);
        //        }
        //    }
        //    Console.Write(count - '0');
        //}

        private static void FloodFill(int i, int j, char count)
        {
            if (i < 0 || i >= r || j < 0 || j >= c)
                return;
            if (m[i, j] == 'O' || m[i, j] !='X')
                return;
            m[i, j] = count;
            FloodFill(i + 1, j, count);
            FloodFill(i - 1, j, count);
            FloodFill(i, j + 1, count);
            FloodFill(i, j - 1, count);
            return;
        }
    }
}
