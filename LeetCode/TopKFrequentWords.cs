using System;
using System.Collections.Generic;
using System.Linq;

namespace DemoConsole.LeetCode
{
    public class TopKFrequentWord
    {
         public IList<string> TopKFrequent(string[] words, int k) 
        {
            if(words ==null || 0 == words.Length || k ==0)
                return null;
            var dict = new Dictionary<string, int>();
            foreach(var word in words)
            {
                if(dict.ContainsKey(word))
                    dict[word]++;
                else
                    dict.Add(word, 1);
            }

            return dict.OrderByDescending(x=> x.Value)
                        .ThenBy(x=> x.Key)
                        .Select( x => x.Key)
                        .Take(k)
                        .ToList();
             
        }
    }
}