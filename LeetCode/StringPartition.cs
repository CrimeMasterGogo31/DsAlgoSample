using System;
using System.Collections.Generic;
using System.Text;

namespace DemoConsole.LeetCode
{
   public class StringPartition
    {
        public IList<int> PartitionLabels(string str)
        {
            int s = 0;
            int e = 1;
            int lastInd = 0;
            int curStart = 0;
            int currPartition = 0; ;
            var res = new List<int>();
            while (s < str.Length )
            {
                if (s < e)
                {
                    var ch = str[s];
                    e = lastInd;
                    while (e < str.Length)
                    {
                        if (str[e] == ch)
                            lastInd = e;
                        e++;
                    }
                    e = lastInd ;
                    s++;
                    currPartition = Math.Max(currPartition, lastInd - curStart+1);
                }
                else
                {
                    if (currPartition > 0)
                        res.Add(currPartition);

                    s=e+1;
                    e=s+1;
                    curStart = s;
                    currPartition = 0;
                    lastInd = s;

                }
            }
            if (currPartition > 0)
                res.Add(currPartition);
            return res;
        }
    }
}
