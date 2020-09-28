using System;
using System.Collections.Generic;
namespace  DemoConsole.Gs
{
    public class FirstNonRepeatingChar
    {
       public char FindFirst(string input)
        {
            if(input == null || 0 == input.Length)
                return '0';

            var arr = new int[26];
            foreach(var ch in input)
            {
               arr[ch - 'a']++;
            }

            foreach(var ch in input)
            {
                if(arr[ch - 'a'] == 1)
                return ch;
            }
            
            return '0';
        }
    }
}