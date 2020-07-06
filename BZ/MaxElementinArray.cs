using System;
using System.Collections.Generic;
using System.Text;

namespace DemoConsole.BZ
{
    class MaxElementinStack
    {
        //public static void Main()
        //{
        //    int t = ReadLineAsInt();
        //    Stack<int> stack = new Stack<int>();
        //    while (t-- != 0)
        //    {

        //        int[] opDetails = ReadLineAsIntArray();

        //        switch (opDetails[0])
        //        {
        //            case 1:
        //                int max;
        //                if (stack.Count == 0)
        //                {
        //                    max = opDetails[1];
        //                }
        //                else if (stack.Peek() > opDetails[1])
        //                {
        //                    max = stack.Peek();
        //                }
        //                else
        //                {
        //                    max = opDetails[1];
        //                }
        //                stack.Push(opDetails[1]);
        //                stack.Push(max);
        //                break;

        //            case 2:
        //                stack.Pop();
        //                stack.Pop();
        //                break;

        //            case 3:
        //                Console.Write(stack.Peek() + " ");
        //                break;

        //        }

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
    }
}
