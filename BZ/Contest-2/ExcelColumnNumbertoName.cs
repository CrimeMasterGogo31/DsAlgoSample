using System;
using System.Collections.Generic;
using System.Text;

namespace DemoConsole.BZ.Contest_2
{
    class ExcelColumnNumbertoName
    {
        static Stack<long> s;
        //static void Main(String[] args)
        //{
        //    /* Enter your code here. Read input from STDIN. Print output to STDOUT. Your class should be named Solution */
        //    int t = Convert.ToInt32(Console.ReadLine());
        //    while (t-- != 0)
        //    {
        //        long num = Convert.ToInt64(Console.ReadLine());
        //        s = new Stack<long>();
        //        ConvertToName(num);
        //        string ss = string.Empty;
        //        while (s.Count > 0)
        //        {
        //            var pop = s.Pop();
        //            if (pop == 0)
        //            {
        //                ss += (char)26;
        //                continue;
        //            }
        //            ss += (char)(pop + 'A' - 1);
        //        }
        //        Console.WriteLine(ss);
        //    }

        //}

        private static void ConvertToName(long num)
        {
            if (num == 0)
            {
                s.Push(26);
                return;
            }
            if (num <= 26)
            {
                s.Push(num);
                //num = num / 26;
                return;
            }
            else
            {
                s.Push(num % 26);
                num /= 26;
                ConvertToName(num);
            }
        }
    }
}
