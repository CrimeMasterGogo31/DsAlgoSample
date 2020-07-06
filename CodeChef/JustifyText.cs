using System;
using System.Collections.Generic;
using System.Text;

namespace DemoConsole.CodeChef
{

    public class JustifyText
    {
        //public static void Main()
        //{
        //    var t = Convert.ToInt32(Console.ReadLine());
        //    while (t-- != 0)
        //    {
        //        var arr = Array.ConvertAll(Console.ReadLine().Trim().Split(' '),
        //        tmp => Convert.ToInt32(tmp));
        //        int n = arr[0];
        //        int line = arr[1];
        //        int i = 0;
        //        var str = new string[n];
        //        while (i < n)
        //        {
        //            str[i++] = Console.ReadLine().Trim();
        //        }
        //        int s = 0;
        //        int e = 0;
        //        int curLine = 0;

        //        while (e < n)
        //        {
        //            if ((curLine + str[e].Length) >= line)
        //            {
        //                Justify(str, s, e - 1, line - curLine);
        //                s = e;
        //                curLine = 0;
        //            }
        //            curLine += (str[e++].Length + 1);

        //        }
        //        if(curLine!=0)
        //        Justify(str, s, e - 1, line - curLine);
        //        Console.WriteLine();
        //    }
        //}

        private static void Justify(string[] str, int s, int e, int spaceRemain)
        {
            int totalSpace = e - s;
            if (totalSpace == 0)
            {
                Console.WriteLine(str[s]);
                return;
            }
            var spaceRank = new int[totalSpace][];
            string[] spaces = new string[totalSpace];
            for (int i = 0; i < totalSpace; i++)
            {
                spaceRank[i] = (new int[] { str[s + i].Length + str[s + i + 1].Length, i });
                spaces[i] = " ";
            }

            var cmp = new compareIntClass();
            Array.Sort(spaceRank, cmp);
            for (int i = 0; i < spaceRemain; i++)
            {
                var ind = i % totalSpace;
                spaces[spaceRank[ind][1]] += " ";
            }

            PrintLine(str, s, e, spaces);

        }

        private static void PrintLine(string[] str, int s, int e, string[] spaces)
        {
            var printLine = string.Empty;
            int c = 0;
            for (int i = s; i <= e; i++)
            {
                printLine += str[i];
                if(c<spaces.Length)
                printLine += spaces[c++];
            }
            Console.WriteLine(printLine);
        }
    }

    public class compareIntClass : IComparer<int[]>
    {

        public int Compare(int[] x, int[] y)
        {
            return y[0] - x[0];
        }
    }

}
