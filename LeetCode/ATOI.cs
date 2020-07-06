using System;
using System.Collections.Generic;
using System.Text;

namespace DemoConsole.LeetCode
{
    public class ATOI
    {
        public int MyAtoi(string str)
        {
            bool isNegetive = false;

            string res = "";
            bool spaceallowed = true;
            bool signallowed = true;

            for (int i = 0; i < str.Length; i++)
            {
                var ch = str[i];
                if ((ch == ' ' && spaceallowed))
                {
                    continue;
                }
                else if ((ch == '-' || ch == '+') && signallowed)
                {
                    if (ch == '-')
                        isNegetive = true;

                    signallowed = false;
                }

                else if ((ch >= '0' && ch <= '9'))
                {
                    res += ch.ToString();
                    signallowed = false;
                }
                else
                {
                    break;
                }
            }

            if (isNegetive)
            {
                string aa = int.MinValue.ToString();
                res = "-" + res;
                if (res.CompareTo(aa) >= 0)
                    return int.Parse(res);
                else
                    return int.MinValue;

            }
            else
            {
                string a = int.MaxValue.ToString();
                if (res.CompareTo(a) >= 0)
                    return int.Parse(res);
                else
                    return int.MaxValue;
            }

        }
    }
}
