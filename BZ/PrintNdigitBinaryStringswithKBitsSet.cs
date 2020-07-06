using System;
using System.Collections.Generic;
using System.Text;

namespace DemoConsole.BZ
{
    class PrintNdigitBinaryStringswithKBitsSet
    {
        static List<int> visited;
        //public static void Main(string[] args)
        //{
        //    int t = ReadLineAsInt();
        //    while (t-- != 0)
        //    {
        //        visited = new List<int>();
        //        int[] rnc = ReadLineAsIntArray();
        //        var n = rnc[0];
        //        var k = rnc[1];
        //        printNBitNumbersWithKBitsSet(n, k);
        //        Console.WriteLine();
        //    }
        //}

        private static void printNBitNumbersWithKBitsSet(int n, int k)
        {
            if (0 == n)
            {
                foreach (var v in visited)
                    Console.Write(v);

                Console.Write(" ");
                return;
            }
            //take 0
            if (n - k > 0)
            {
                visited.Add(0);
                printNBitNumbersWithKBitsSet(n - 1, k);
                visited.RemoveAt(visited.Count - 1);
            }

            // take 1
            if (k > 0)
            {  
                visited.Add(1);
                printNBitNumbersWithKBitsSet(n - 1, k - 1);
                visited.RemoveAt(visited.Count - 1);

            }
        }

        static int ReadLineAsInt()
        {
            return Convert.ToInt32(Console.ReadLine().Trim());
        }

        static int[] ReadLineAsIntArray()
        {
            return Array.ConvertAll(Console.ReadLine().Trim().Split(' '), wTemp => Convert.ToInt32(wTemp));
        }
    }
}
