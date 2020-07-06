using System;
using System.Collections.Generic;

//class BeingZero
//{
//    static Dictionary<string, string> dict;
//    static List<char> path;
//    static void FillDict()
//    {
//        dict = new Dictionary<string, string>();
//        dict.Add("2", "abc");
//        dict.Add("3", "def");
//        dict.Add("4", "ghi");
//        dict.Add("5", "jkl");
//        dict.Add("6", "mno");
//        dict.Add("7", "pqrs");
//        dict.Add("8", "tuv");
//        dict.Add("9", "wxyz");
//    }
//    public static void Main(string[] args)
//    {
//        FillDict();
//        int t = Convert.ToInt32(Console.ReadLine().Trim());
//        while (t-- != 0)
//        {
//            int n = Convert.ToInt32(Console.ReadLine().Trim());
//            path = new List<char>();
//            PrintPath(n.ToString(), 0);
//            Console.WriteLine();
//            Console.WriteLine();
//        }

//    }
//    static void PrintPath(string n, int c)
//    {
//        if (c == (n.Length))
//        {
//            foreach (var i in path)
//                Console.Write(i);
//            Console.Write(" ");
//            return;
//        }


//        var t = n[c];
//        var values = dict[t.ToString()];
//        foreach (var val in values)
//        {
//            path.Add(val);
//            PrintPath(n, c + 1);
//            path.RemoveAt(path.Count - 1);
//        }
//    }


//}
