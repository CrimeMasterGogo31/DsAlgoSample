using System;
using System.Collections.Generic;
using System.Text;

namespace DemoConsole.BeingZero
{
    public class AverageOfTwoNumber
    {
        public void test() {

            var input = Console.ReadLine();
            string[] val_array = input.Split(" ");
            double x = Convert.ToDouble(val_array[0]);
            double y = Convert.ToDouble(val_array[1]);
            double z = Convert.ToDouble(val_array[2]);
            double res = (x + y + z) / 3;
            Console.Write(res.ToString("F"));
        }
    }
}
