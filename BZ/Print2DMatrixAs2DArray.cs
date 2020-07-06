using System;
using System.Collections.Generic;
using System.Text;

namespace DemoConsole.BZ
{
    class Print2DMatrixAs2DArray
    {
        static void printDiagonally(List<List<int>> mat)
        {
            int r = mat.Count;
            int c = mat[0].Count;
            int i = 0, j = 0;
            for (int k = 0; k < r; k++)
            {

                i = k;
                j = 0;
                while (i >= 0 && j < c)
                {
                    Console.Write(mat[i][j] + " ");
                    i = i - 1;
                    j = j + 1;
                }
                Console.WriteLine();
            }

            for (int k = 1; k < c; k++)
            {
                i = r - 1;
                j = k;
                while (j <= c - 1)
                {
                    Console.Write(mat[i][j] + " ");
                    i = i - 1;
                    j = j + 1;
                    if (i < 0 || j < 0)
                        break;

                }
                Console.WriteLine();
            }
        }
    }
}
