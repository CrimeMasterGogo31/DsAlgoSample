using System;
using System.Collections.Generic;
using System.Text;

namespace DemoConsole.BeingZero
{
    class NegateNumberWithoutUsingMinus
    {
        //public static void Main(string[] args)
        //{
        //    int n = Convert.ToInt32(Console.ReadLine());
        //    while (n-- > 0)
        //    {
        //        var x = Convert.ToInt32(Console.ReadLine());

        //        negateNumber(x);

        //    }
        //}
        public static void negateNumber(int x)
        {
            Console.WriteLine(~x + 1);
        }
    }
}
