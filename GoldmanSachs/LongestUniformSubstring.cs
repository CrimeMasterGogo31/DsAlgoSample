using System;

namespace DemoConsole.Gs
{
    public class LongestUniformSubstringClass
    {
        public int[] LongestUniformSubstring(string input)
        {
            if(string.IsNullOrEmpty(input)) 
                return new int[]{ -1, -1};

            int s =0, e =1;
            int max =0;
            var res = new int[2];
            while(s < input.Length && e < input.Length) //abbbccda  4 6
            {
                if(input[s] != input[e])
                {
                    if(max < (e-s))
                    {
                        max = e - s;
                        res[0] = s;
                        res[1] = e-s;
                    }
                    s = e;

                }
                e++;
            }
            
            if(max < (e-s))
            {
                max = e -s;
                res[0] = s;
                res[1] = e-s;
            }

            return res;
        }
    }
    
}