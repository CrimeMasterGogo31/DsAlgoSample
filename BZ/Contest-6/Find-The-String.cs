using System;
using System.Collections.Generic;
using System.IO;
class Solution2
{
    static char[,] m;
    static bool[,] store;
    static HashSet<string> set;
    //static void Main(String[] args)
    //{
    //    /* Enter your code here. Read input from STDIN. Print output to STDOUT. Your class should be named Solution */
    //    var t = Convert.ToInt32(Console.ReadLine());
    //    while (t-- != 0)
    //    {
    //        var input = Console.ReadLine().Split(' ');
    //        var r = Convert.ToInt32(input[0]);
    //        var c = Convert.ToInt32(input[1]);
    //        m = new char[r, c];
    //        for (int i = 0; i < r; i++)
    //        {
    //            var rows = Console.ReadLine().Trim();
    //            for (int j = 0; j < c; j++)
    //            {
    //                m[i, j] = rows[j];
    //            }
    //        }

    //        var q = Console.ReadLine().Trim();
    //        int cur_r = 0;
    //        int cur_c = 0;
    //        bool currentMatch = false;
    //        set = new HashSet<string>();
    //        foreach (char s in q)
    //        {
    //            currentMatch = false;
    //            for (int j = 0; j < c; j++)
    //            {
    //                //string key = "r" + cur_r + "c" + j + s.ToString();
    //                if (s == m[cur_r, j] && !store[cur_r, j])
    //                {
    //                    currentMatch = true;
    //                    //set.Add(key);
    //                    store[cur_r, j] = true;
    //                    break;
    //                }
    //            }
    //            if (currentMatch)
    //            {
    //                cur_r = (cur_r + 1) % r;
    //                cur_c = 0;

    //            }
    //            else
    //            {
    //                break;
    //            }

    //        }

    //        if (currentMatch)
    //            Console.WriteLine("Yes");
    //        else
    //        {
    //            Console.WriteLine("No");
    //        }
    //    }
    //}
}