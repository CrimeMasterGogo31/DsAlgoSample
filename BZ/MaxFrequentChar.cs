using System;
using System.Collections.Generic;
using System.Linq;

class BeingZero1
{
    public void lastMostFrequentCharacter(char[] s)
    {
        char a = s[0];
        int max = 0;
        char c = 'x';
        Dictionary<char, int> dic = new Dictionary<char, int>();
        for (int i = 0; i < s.Length; i++)
        {
            if (s[i] == ' ')
                continue;
            if (dic.ContainsKey(s[i]))
            {
                dic[s[i]]++;
            }
            else
            {
                dic.Add(s[i], 1);
            }

        }

        foreach (KeyValuePair<char, int> k in dic)
        {
            if (k.Value > max)
            {
                max = k.Value;
                c = k.Key;
            }

        }

        Console.Write(c + " " + max);

    }


}

class Test1
{
    static int ReadInteger()
    {
        return Convert.ToInt32(Console.ReadLine());
    }
    
}