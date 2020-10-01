using System;


namespace DemoConsole.Gs
{

    public class Panagram
    {
        public string FindMissingLetters(string sentence)
        {
            var arr = new int[26];
            sentence = sentence.ToLower();

            foreach(var ch in sentence)
            {
                if(ch >= 'a' && ch <= 'z')
                    arr[ch - 'a'] ++;
                
            }
            var res = "";
            for(int i =0; i <26; i++)
            {
                if(arr[i] == 0)
                    res += Convert.ToChar('a' + i).ToString();
            }

            return res;
        }
    }
}