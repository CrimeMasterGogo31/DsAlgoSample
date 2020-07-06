using System;
using System.Collections.Generic;
using System.Text;

namespace DemoConsole.LeetCode
{
  public  class AnagramInString
    {
        public IList<int> FindAnagrams(string s, string p)
        {
            var pArr = p.ToCharArray();
            Array.Sort(pArr, (x, y) => x - y);
            p = new string(pArr);
            var result = new List<int>();
            for (int i = 0; i < s.Length - p.Length; i++)
            {
                var temp = p.Substring(i, p.Length);
                var tArr = temp.ToCharArray();
                Array.Sort(tArr, (x, y) => x - y);
                temp = new string(tArr);
                if (temp == p)
                    result.Add(i);

            }


            return result;
        }
    }
}
