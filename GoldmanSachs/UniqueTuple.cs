using System;
using System.Collections.Generic;
using System.Linq;

namespace DemoConsole.Gs{
    public class UniqueTupleClass
    {
        // Assumption : given word is lower case  
        public List<string> UniqueTuple(string word, int len)
        {
            var res = new List<string>();
            if(len > word.Length || len <= 0)
                return res;
            
            if(len == word.Length)
            {
                res.Add(word);
                return res;
            }
            var set = new HashSet<string>();
            for(int i =0; i< word.Length- len +1; i ++)
            {
                var str = word.Substring(i, len);
                if(!set.Contains(str))
                    set.Add(str);
            }

            res = set.ToList();
            return res;
        }
    }
}