using System;

namespace DemoConsole.Gs
{
    public class ReveseString
    {
        public string Reverse(string input)
        {
            if(string.IsNullOrEmpty(input))
                return "";
                
            var res = input.ToCharArray();
            int start = 0;
            int end = input.Length-1;

            while(start < end)
            {
                if(res[start] != res[end])
                {
                    var t = res[start];
                    res[start] = res[end];
                    res[end] = t;
                }
                start++; end--;
            }

            return new string(res);
        }
    }
}