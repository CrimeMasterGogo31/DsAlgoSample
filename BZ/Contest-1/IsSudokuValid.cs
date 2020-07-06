using System;
using System.Collections.Generic;
using System.Text;

namespace DemoConsole.BZ.Contest_1
{
    class IsSudokuValidClass
    {
        static char[,] m;
        //static void Main(String[] args)
        //{
        //    int t = Convert.ToInt32(Console.ReadLine());
        //    while (t-- != 0)
        //    {
        //        m = new char[9, 9];
        //        for (int i = 0; i < 9; i++)
        //        {
        //            var rows = Array.ConvertAll(Console.ReadLine().Trim().Split(' '), wTemp => Convert.ToChar(wTemp));
        //            for (int j = 0; j < 9; j++)
        //            {
        //                m[i, j] = rows[j];
        //            }
        //        }
        //        if (IsSudokuValid())
        //        {
        //            Console.WriteLine("Valid");
        //        }
        //        else
        //        {
        //            Console.WriteLine("Invalid");

        //        }
        //    }
        //}

        private static bool IsSudokuValid()
        {
            for (int i = 0; i < 9; i++)
            {
                var arr = new int[10];
                for (int j = 0; j < 9; j++)
                {
                    if (m[i, j] > '0' && m[i, j] <= '9')
                    {
                        if (arr[m[i, j] - '0'] == -1)
                            return false;
                        else
                            arr[m[i, j] - '0'] = -1;
                    }
                    else
                    {
                        return false;
                    }
                }
                if (!ArraySum(arr))
                    return false;
            }

            for (int i = 0; i < 9; i++)
            {
                //int sum = (9 * 10) / 2;
                var arr = new int[10];

                for (int j = 0; j < 9; j++)
                {
                    if (m[j, i] > '0' && m[j, i] <= '9')
                    {
                        if (arr[m[i, j] - '0'] == -1)
                            return false;
                        else
                            arr[m[i, j] - '0'] = -1;
                    }
                    else
                    {
                        return false;
                    }
                }
                if (!ArraySum(arr))
                    return false;
            }

            for (int r = 0; r < 3; r++)
            {
                for (int c = 0; c < 3; c++)
                {
                    var arr = new int[10];

                    for (int i = 0; i < 3; i++)
                    {

                        for (int j = 0; j < 3; j++)
                        {
                            if (m[(r * 3) + i, (c * 3) + j] > '0' && m[(r * 3) + i, (c * 3) + j] <= '9')
                            {
                                //sum -= (m[(r * 3) + i, (c * 3) + j] - '0');

                                if (arr[m[(r * 3) + i, (c * 3) + j] - '0'] == -1)
                                    return false;
                                else
                                    arr[m[(r * 3) + i, (c * 3) + j] - '0'] = -1;
                            }
                            else
                            {
                                return false;
                            }
                        }
                    }
                }
            }

            return true;
        }

        private static bool ArraySum(int[] arr)
        {
            var sum = 0;
            foreach (var l in arr)
            {
                sum += l;
            }
            return sum == -9;
        }
    }
}
