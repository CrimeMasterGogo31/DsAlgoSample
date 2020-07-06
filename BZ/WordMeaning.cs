using System;
using System.Collections.Generic;
using System.Text;

namespace DemoConsole.BeingZero
{
    class WordMeaning
    {
        static Dictionary<string, string> dic = new Dictionary<string, string>();
        static string[] a;
        //public static void Main(string[] args)
        //{
        //    int t = ReadInteger();
        //    a = new string[t];
           

        //    for (int i = 0; i < t; i++)
        //    {
        //        a[i] = Console.ReadLine();
        //    }
        //    int q = ReadInteger();
        //    while (q-- != 0)
        //    {
        //        string input = Console.ReadLine().Trim();
        //        Console.WriteLine(GetMeaning(input));
                
        //    }

        //}
        static int ReadInteger()
        {
            return Convert.ToInt32(Console.ReadLine());
        }
        static string GetMeaning(string input)
        {

            if (dic.ContainsKey(input))
            {
                return dic[input];
            }
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i].StartsWith(input))
                {
                    dic.Add(input.ToUpper(), a[i].Substring(input.Length).Trim().ToUpper());
                    break;
                }
            }
            return dic[input.ToUpper()];
        }
    }
}
