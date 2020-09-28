using System;
using System.Collections.Generic;

namespace  DemoConsole.Gs
{
    public class GroupAnagramClass
    {
        public IList<IList<string>> GroupAnagrams(string[] strs) 
        {
            var res = new List<IList<string>>();
            if(strs==null || 0 == strs.Length)
                return res;
            
            var dict = new Dictionary<string, List<string>>();
            
            foreach(var str in strs)
            {
                var charr = str.ToCharArray();
                Array.Sort(charr, (x,y)=> x-y);
                var s = new String(charr);
                if(dict.ContainsKey(s))
                {
                    dict[s].Add(str);
                }
                else
                    dict.Add(s,new List<string>(){str});
            }
            
            
            foreach(var d in dict)
            {
                res.Add(d.Value);
            }
            return res;
        }
    }
    
}