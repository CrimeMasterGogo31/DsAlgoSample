using System;
using System.Collections.Generic;
using System.Text;

namespace DemoConsole.LeetCode
{
    public class GenerateParenthesisClass
    {
        public IList<string> GenerateParenthesis(int n)
        {
            int oc = n;
            int cc = n;
            var res = new List<string>();
            Populate(n, oc, cc, res, "");
            return res;
        }

        void Populate(int n, int oc, int cc, IList<string> list, string val)
        {
            if (val.Length == n * 2)
            {
                list.Add(val);
                return;
            }
            if (oc > 0)
            {
                val += "(";
                Populate(n, oc - 1, cc, list, val);
                val = val.Substring(0,val.Length - 1);
            }

            if (cc > oc && cc > 0)
            {
                val += ")";
                Populate(n, oc, cc - 1, list, val);
                val = val.Substring(0, val.Length - 1);
            }

        }
    }
}
