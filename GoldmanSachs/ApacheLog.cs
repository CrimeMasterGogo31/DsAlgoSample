using System;
using System.Collections.Generic;

namespace DemoConsole.Gs
{
    public class ApacheLog
    {
        public string FindTopIPAddress(string[] lines){
            var result ="";
            if(lines == null || 0 == lines.Length)
                return result;

            var dict = new Dictionary<string, int>();

            foreach(var line in lines)
            {
                var ip  = line.Split("-")[0].Trim();

                if(dict.ContainsKey(ip))
                    dict[ip]++;
                else
                    dict.Add(ip, 1);
            }

            var max =0;
            foreach(var kv in dict)
            {
                if(kv.Value > max)
                {
                    max = kv.Value;
                    result = kv.Key;
                }
                else if(kv.Value == max)
                {
                    result += "," + kv.Key;
                }
            }
            return result;
        }
    }
}
