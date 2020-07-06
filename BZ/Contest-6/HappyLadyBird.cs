using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;

class Solution
{

    // Complete the happyLadybugs function below.
    static string happyLadybugs(string b)
    {
        Dictionary<char, int> dict = new Dictionary<char, int>();
        bool isUnderscorePresent = false;
        if (b.Length == 1 && b == "_")
            return "YES";
        if(b.Length == 1 && b != "_")
            return "NO";

        foreach (var c in b)
        {
            if (dict.ContainsKey(c))
                dict[c]++;
            else
                dict.Add(c, 1);
            if (c == '_')
                isUnderscorePresent = true;
        }
        for (int i = 0; i < b.Length - 1; i++)
        {
            if (b[i] == '_') continue;
            if (b[i] == b[i + 1])
                continue;
            else
            {
                
                if(dict[b[i]] < 2 && !isUnderscorePresent)
                    return "NO";
            }

        }
        return "YES";

    }

    //static void Main(string[] args)
    //{

    //    int g = Convert.ToInt32(Console.ReadLine());

    //    for (int gItr = 0; gItr < g; gItr++)
    //    {
    //        int n = Convert.ToInt32(Console.ReadLine());

    //        string b = Console.ReadLine();

    //        string result = happyLadybugs(b);
    //        Console.WriteLine(result);

    //    }

    //}
}
