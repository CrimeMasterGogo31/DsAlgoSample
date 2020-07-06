using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace DemoConsole.BeingZero
{
    class Test
    {
        //public static void Main(string[] args)
        //{
        //    int t = ReadLineAsInt();
        //    while (t-- != 0)
        //    {
        //        HashSet<int> set = new HashSet<int>();

        //        int opsCount = ReadLineAsInt();

        //        for (int op = 1; op <= opsCount; op++)
        //        {
        //            int[] opDetails = ReadLineAsIntArray();

        //            switch (opDetails[0])
        //            {
        //                case 0:
        //                    set.Add(opDetails[1]);
        //                    break;

        //                case 2:
        //                    set.Remove(opDetails[1]);
        //                    break;

        //                case 1:
        //                    Console.Write(set.Contains(opDetails[1]).ToString().ToLower() + " ");
        //                    break;

        //            }

        //        }

        //        Console.WriteLine();
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
