using System;
using System.Collections.Generic;
using System.Text;

namespace DemoConsole.BZ
{
    //Google Question
    class RepeatedAndMissingNumber
    {
        public static void printRepeatedAndMissingElement(int[] a)
        {
            int xor_given = 0;//[3 1 2 5 3]
            int xor_actual = 0; //[1 2 3 4 5] ^4^3
            for (int i = 0; i < a.Length; i++)
            {
                xor_actual ^= (i + 1);
                xor_given ^= a[i];
            }
            int xor = xor_actual ^ xor_given;

            int mask = xor & -xor;
            int first = 0;
            int second = 0;

            for (int i = 0; i < a.Length; i++)
            {
                if (0 == (mask & a[i]))
                {
                    first ^= a[i];
                }
                else
                {
                    second ^= a[i];
                }
                if (0 == (mask & (i + 1)))
                {
                    first ^= (i + 1);
                }
                else
                {
                    second ^= (i + 1);
                }
            }
            int repeated = 0;
            for (int i = 0; i < a.Length; i++) {
                if (a[i] == first)
                {
                    repeated = first;
                    break;
                }
                if (a[i] == second)
                {
                    repeated = second;
                    break;
                }

            }

            if (repeated == first) {
                Console.Write(first + " " + second);
            }
            else
            Console.Write(second + " " + first);
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
        //        printRepeatedAndMissingElement(a);
        //    }
        //}
    }
}
