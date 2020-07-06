using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DemoConsole.BeingZero
{
    class PriorityQueue
    {
        //public static void Main(string[] args)
        //{
        //    int t = ReadLineAsInt();
        //    while (t-- != 0)
        //    {
        //        List<int> pq = new List<int>();
        //        int i = -1;
        //        int opsCount = ReadLineAsInt();

        //        for (int op = 1; op <= opsCount; op++)
        //        {
        //            int[] opDetails = ReadLineAsIntArray();
        //            switch (opDetails[0])
        //            {
        //                case 0:
        //                    pq.Add(opDetails[1]);
        //                    i++;
        //                    break;
        //                case 1:
        //                    Console.Write(pq[i] + " ");
        //                    break;
        //                case 2:
        //                    Console.Write(pq.Count + " ");
        //                    break;
        //                case 3:
        //                    Console.Write(pq[i] + " ");
        //                    pq.RemoveAt(i--);
        //                    break;
        //            }
        //        }

        //    }
        //}
        static int ReadLineAsInt()
        {
            return Convert.ToInt32(Console.ReadLine().Trim());
        }

        static int[] ReadLineAsIntArray()
        {
            return Array.ConvertAll(Console.ReadLine().Trim().Split(' '), wTemp => Convert.ToInt32(wTemp));
        }

        static List<int> ReadLineAsIntList()
        {
            int[] a = ReadLineAsIntArray();
            return a.OfType<int>().ToList();
        }
    }
}
