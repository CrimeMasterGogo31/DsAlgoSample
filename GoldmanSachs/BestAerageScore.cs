using System;
using System.Collections.Generic;
using System.Linq;

namespace DemoConsole.Gs
{
    public class BestAverageScore
    {
        public int BestAverageGrade(string[][] scores) 
        {
            var dict = new Dictionary<string, float[]>();

            foreach(var score in scores)
            {
                if(dict.ContainsKey(score[0]))
                {
                    dict[score[0]][0] += Convert.ToInt64(score[1]);
                     dict[score[0]][1] ++;
                }
                else
                {
                    dict.Add(score[0], new float []{ Convert.ToInt64(score[1]), 1 });
                }
            }

            foreach(var kv in dict)
                kv.Value[0] = Convert.ToInt32(Math.Floor(kv.Value[0] / kv.Value[1]));
            
            var result = dict.OrderByDescending(x => x.Value[0]).Take(1).Select(x => x.Value[0]).First();
            return Convert.ToInt32(result);
        }

    }
}