using System;
using System.Collections.Generic;
using System.Text;

namespace DemoConsole.Gs
{
    public class LongestWordClass
    {
        public HashSet<string> LongestWord(string[] dictionary , string str) // aa {a=2}  aaa {a=3}
        {
            if(str == null || dictionary == null || 0 == dictionary.Length)
            return null;
        
            var sarr = str.ToCharArray();
            Array.Sort(sarr , (x, y) => x-y);

            var max = 0;
            var res = new HashSet<string>();
            foreach(var word in dictionary)
            {
                if(word.Length > str.Length)
                    continue;
                
                var warr = word.ToCharArray();
                Array.Sort(warr, (x, y) => x-y);

                int wind=0,sind=0;
                while(wind < warr.Length)
                {
                    if(warr[wind] == sarr[sind])
                    {
                        wind++;
                        sind++;
                    } 
                    else
                    {
                        while(sarr[sind] < warr[wind] && sind < sarr.Length)
                            sind++;
                        if(sind == sarr.Length || sarr[sind] != warr[wind])
                            break;
                    }
                }
                if(wind == warr.Length)
                {
                    if(max < wind)
                    {
                        max = wind;
                        res = new HashSet<string>();
                        res.Add(word);   
                    }
                    else if(max == wind)
                    {
                        res.Add(word);
                    }
                }
            }

            return res;
        }
    }
}