using System;
using System.Collections.Generic;
using System.Text;

namespace DemoConsole.BZ.Contest_4
{
    using System;

    class Test
    {
        //public static void Main()
        //{
        //    var line = Console.ReadLine().Trim().Split(' ');
        //    int n = Convert.ToInt32(line[0]);
        //    int t = Convert.ToInt32(line[1]);
        //    while (t-- != 0)
        //    {
        //        var arr = Array.ConvertAll(Console.ReadLine().Trim().Split(' '),
        //        tmp => Convert.ToInt32(tmp));


        //        int i = arr.Length - 2;
        //        while (i >= 0 && arr[i + 1] <= arr[i])
        //        {
        //            i--;
        //        }
        //        if (i >= 0)
        //        {
        //            int j = arr.Length - 1;
        //            while (j >= 0 && arr[j] <= arr[i])
        //            {
        //                j--;
        //            }
        //            Swap(arr, i, j);
        //        }

        //        Reverse(arr, i + 1);

        //        PrintA(arr);
        //    }

        //}

        static void Swap(int[] arr, int i, int j)
        {
            var t = arr[i];
            arr[i] = arr[j];
            arr[j] = t;
        }

        static void Reverse(int[] arr, int s)
        {
            int i = s;
            int j = arr.Length - 1;
            while (i < j)
            {
                Swap(arr, i, j);

                i++;
                j--;
            }

        }

        static void PrintA(int[] arr)
        {
            foreach (var i in arr)
                Console.Write(i + " ");
            Console.WriteLine();

        }


    }
}
