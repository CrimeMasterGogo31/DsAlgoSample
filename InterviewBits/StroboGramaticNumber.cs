using System;
using System.Collections.Generic;
using System.Text;

namespace DemoConsole.InterviewBits
{
    class StroboGramaticNumber
    {
        int count;
        Dictionary<char, char> dict;
        char[] nums = new char[5] { '0', '1', '8', '6', '9' };
        public int solve(string A, string B)
        {
            if (A == null || A.Length == 0 || B == null || B.Length == 0)
            {
                return 0;
            }
            this.count = 0;
            FillDict();

            for (int n = A.Length; n <= B.Length; n++)
            {
                char[] arr = new char[n];
                StrobogramamticNumber(arr, A, B, 0, n - 1);

            }
            return count;
        }

        void StrobogramamticNumber(char[] arr, string min, string max, int start, int end)
        {
            if (start > end)
            {
                string s = new string(arr);
                if (s.Length == 1 || (s[0] != '0' && Compare(min, s) && Compare(s, max)))
                    count++;

                return;
            }

            foreach (var c in this.nums)
            {
                arr[start] = c;
                arr[end] = dict[c];
                if (start < end || (start == end && c == dict[c]))
                    StrobogramamticNumber(arr, min, max, start + 1, end - 1);
            }
        }

        bool Compare(String s1, String s2)
        {
            if (s1.Length == s2.Length)
            {
                if (s1.CompareTo(s2) <= 0)
                    return true;
                else
                    return false;
            }
            return true;
        }

        void FillDict()
        {
            this.dict = new Dictionary<char, char>();
            this.dict.Add('0', '0');
            this.dict.Add('1', '1');
            this.dict.Add('8', '8');
            this.dict.Add('9', '6');
            this.dict.Add('6', '9');
        }
    }

}
