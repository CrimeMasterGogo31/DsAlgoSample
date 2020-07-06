using System;
using System.Collections.Generic;
using System.Text;

namespace DemoConsole.BeingZero
{
    public class AddingTwoBigIntegersClass
    {
        public void test()
        {

            string input = Console.ReadLine();
            string x = input.Split(" ")[0];
            string y = input.Split(" ")[1];
            var x_arr = x.ToCharArray();
            var y_arr = y.ToCharArray();
            int unitSum = 0;
            int c = 0;
            int min_len = x_arr.Length < y_arr.Length ? x_arr.Length : y_arr.Length;
            Stack<int> sum = new Stack<int>();
            int i, j;
            for (i = x_arr.Length-1, j = y_arr.Length-1; i >= 0 && j >= 0; i--, j--)
            {
                unitSum = (int)x_arr[i] + (int)y_arr[j] + c;
                c = unitSum / 10;
                sum.Push(unitSum);
            }
            int remainingLen = 0;
            char[] rem_array = new char[min_len];
            if (i++ != 0)
            {
                remainingLen = i;
                rem_array = x_arr;
            }
            if (j++ != 0)
            {
                remainingLen = j;
                rem_array = y_arr;
            }

            if (remainingLen > 0)
            {
                for (int z = remainingLen; z >= 0; z--)
                {
                    unitSum = (int)rem_array[z] + c;
                    c = unitSum / 10;
                    sum.Push(unitSum);
                }
            }

            while (sum.Peek() != 0)
            {
                Console.Write(sum.Pop());
            }
        }

        public void AddingTwoBigIntegers()
        {
            var input = Console.ReadLine();
            var input_arrayPlace = input.Split(' ');
            string x = Convert.ToString(input_arrayPlace[0]);
            string y = Convert.ToString(input_arrayPlace[1]);
            if (x.Length > y.Length)
            {
                string t = x;
                x = y;
                y = t;
            }
            string str = "";
            int n1 = x.Length, n2 = y.Length;
            char[] ch = x.ToCharArray();
            Array.Reverse(ch);
            x = new string(ch);
            char[] ch1 = y.ToCharArray();
            Array.Reverse(ch1);
            y = new string(ch1);
            int carry = 0;
            for (int i = 0; i < n1; i++)
            {
                int sum = ((int)(x[i] - '0') +
                        (int)(y[i] - '0') + carry);
                str += (char)(sum % 10 + '0');

                carry = sum / 10;
            }
            for (int i = n1; i < n2; i++)
            {
                int sum = ((int)(y[i] - '0') + carry);
                str += (char)(sum % 10 + '0');
                carry = sum / 10;
            }
            if (carry > 0)
                str += (char)(carry + '0');

            char[] ch2 = str.ToCharArray();
            Array.Reverse(ch2);
            str = new string(ch2);
            Console.WriteLine(str);
            Console.Read();
        }
    }
}
