using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DemoConsole.BeingZero
{
    class DictionaryOperations
    {
        //public static void Main(string[] args)
        //{
        //    int t = ReadLineAsInt();
        //    //BeingZero bz = new BeingZero();
        //    while (t-- != 0)
        //    {
        //        Dictionary<int, int> dict = new Dictionary<int, int>();

        //        int opsCount = ReadLineAsInt();

        //        for (int op = 1; op <= opsCount; op++)
        //        {
        //            int[] opDetails = ReadLineAsIntArray();

        //            switch (opDetails[0])
        //            {
        //                case 0:
        //                    if (!dict.ContainsKey(opDetails[1]))
        //                    {
        //                        dict.Add(opDetails[1], opDetails[2]);

        //                    }
        //                    else
        //                    {
        //                        dict[opDetails[1]] = opDetails[2];
        //                    }

        //                    break;

        //                case 1:
        //                    Console.Write(dict.ContainsKey(opDetails[1]).ToString().ToLower() + " ");
        //                    break;

        //                case 2:
        //                    Console.Write(dict[opDetails[1]] + " ");
        //                    break;

        //                case 3:
        //                    Console.Write(dict.Keys.Count + " ");
        //                    break;
        //                case 4:
        //                    dict.Remove(opDetails[1]);
        //                    break;
        //                default:
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
