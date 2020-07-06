using System;
using System.Collections.Generic;
using System.Text;

namespace DemoConsole.BZ
{
    class TwoNonRepeatingInteger
    {
        public static void printTwoNRIntegers(int[] a)
        {
            int xor = 0;
            for (int i = 0; i < a.Length; i++)
            {
                xor ^= a[i];
            }
            int mask = xor & -xor;
            int first = 0;
            int second = 0;
            for (int i = 0; i < a.Length; i++)
            {
                if (0 == (a[i] & mask))
                {
                    first ^= a[i];
                }
                else
                {
                    second ^= a[i];
                }
            }
            if (first < second)
            {
                Console.Write(first + " " + second);
            }
            else {

                Console.Write(second + " " + first);
            }
            Console.WriteLine();

        }
        //public static void Main(string[] args)
        //{
        //    int t = Convert.ToInt32(Console.ReadLine());
        //    while (t-- != 0)
        //    {
        //        int size = Convert.ToInt32(Console.ReadLine());
        //        int[] a = new int[size];
        //        if (size > 0)
        //        {
        //            string[] parts = Console.ReadLine().Split(' ');
        //            int i = 0;
        //            foreach (string p in parts)
        //                a[i++] = Convert.ToInt32(p);

        //        }
        //        printTwoNRIntegers(a);
        //    }
        //}
    }
}
