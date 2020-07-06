using System;
using System.Collections.Generic;
using System.Text;

namespace DemoConsole.BeingZero
{
    public class SumofTwoWithoutPlusOperator
    {
        //public static void Main(string[] args)
        //{
        //    int n = Convert.ToInt32(Console.ReadLine());
        //    while (n > 0)
        //    {
        //        var input = Console.ReadLine();
        //        var input_array = input.Split(" ");
        //        int x = Convert.ToInt32(input_array[0]);
        //        int y = Convert.ToInt32(input_array[1]);
        //        addNumbersWithoutUsingPlus(x, y);
        //        n--;
        //    }
        //}
        public static void addNumbersWithoutUsingPlus(int x, int y)
        {

            while (y > 0)
            {
                x++;
                y--;
            }
            Console.WriteLine(x);
        }
    }
}
