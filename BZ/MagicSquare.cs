using System;
using System.Collections.Generic;
using System.Text;

namespace DemoConsole.BZ
{
    class MagicSquare
    {
        static void fillMagicSq(int[,] mat, int n)
        {
            //pos for 1
            int i = n / 2;
            int j = n - 1;
            for (int num = 1; num <= n * n;)
            {
               
                if (mat[i, j] != 0)
                {
                    j =(j-1)%n;
                    i =(i+2)% n;
                    continue;
                }
                else
                    mat[i, j] = num++;
                j = (j + 1) % n;
                i = (i - 1) % n;
            }
        }
        static bool validateMagicSq(int[,] ms)
        {
            int n = ms.GetLength(0);
            int sumr = 0, sumc = 0, sumd = 0, sume = 0, actualSum = (n * (n * n + 1)) / 2;
            for (int i = 0; i < n; i++)
            {
                sumr = sumc = sumd = sume = 0;
                for (int j = 0; j < n; j++)
                {
                    sumr += ms[i, j];
                    sumc += ms[j, i];
                    sumd += ms[j, j];
                    sume += ms[j, n - j - 1];
                }
                if (actualSum != sumr || actualSum != sumc || actualSum != sumd || actualSum != sume)
                    return false;
            }
            return true;
        }
        static void printMatrix(int[,] mat)
        {
            int n = mat.GetLength(0); // Rows
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                    Console.Write("{0} ", mat[i, j]);
                Console.WriteLine();
            }
            Console.WriteLine();
        }
        //static void Main(String[] args)
        //{
        //    int t = Convert.ToInt32(Console.ReadLine());
        //    while (t-- != 0)
        //    {
        //        int n = Convert.ToInt32(Console.ReadLine());
        //        int[,] mat = new int[n, n];
        //        fillMagicSq(mat, n);
        //        // printMatrix(mat);
        //        Console.WriteLine(validateMagicSq(mat) ? "true" : "false");
        //    }
        //}

    }
}
