using System;
using System.Collections.Generic;
using System.Text;

namespace DemoConsole.BeingZero
{
    class printAlternateSignWithoutMultiplesOfFourlass
    {
        //public static void Main(string[] args)
        //{
        //    int n = Convert.ToInt32(Console.ReadLine());
        //    while (n-- > 0)
        //    {
        //        var x = Convert.ToInt32(Console.ReadLine());

        //        printAlternateSignWithoutMultiplesOfFour(x);

        //    }
        //}

        private static void printAlternateSignWithoutMultiplesOfFour(int x)
        {
            bool sign = true;
            int val = 1;
            var count = x;
            while (count != 0) {
                if (val % 4 != 0)
                {
                    var signval = sign ? 1 : -1 ;
                    Console.Write(val*signval + " ");
                    sign = !sign;
                    count--;
                }
                val++;
                
            }
        }
    }
}
