using System;
using System.Collections.Generic;
using System.Text;

namespace DemoConsole.BeingZero
{
    class BeingZero
    {
        static int x;

        //public static void Main(string[] args)
        //{
        //    string line = "";
        //    while ((line=Console.ReadLine())!=null) {
        //        int n = Convert.ToInt32(line);
        //        x = n;
        //        Console.Write(n + " ");

        //        if (n > 0)
        //        {
        //            printPattern(n - 5, false);
        //        }
        //        Console.WriteLine();
        //    }

        //}
        public static void printPattern(int n, bool isAddition = true)
        {
            Console.Write(n + " ");
            if (n == x)
            {
                return;
            }
            if (!isAddition)
            {
                if (n <= 0)
                {
                    printPattern(n + 5, true);
                    return;
                }
                printPattern(n - 5, false);
                return;
            }
            {
                printPattern(n + 5);
                return;
            }
        }
    }
}
