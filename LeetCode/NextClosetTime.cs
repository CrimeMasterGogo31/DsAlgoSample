using System;
using System.Collections.Generic;
using System.Text;

namespace DemoConsole.LeetCode
{
    public class NextClosetTime
    {
        public string NextClosestTime(string time)
        {
            var comb = new List<string>();
            var digits = new char[4];
            int c = 0;
            foreach (var cha in time)
            {
                if (cha != ':')
                {
                    digits[c] = cha;
                    c++;
                }
            }
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    for (int k = 0; k < 4; k++)
                    {
                        for (int l = 0; l < 4; l++)
                        {
                            var str = $"{digits[i]}{digits[j]}{digits[k]}{digits[l]}";
                            comb.Add(str);
                        }
                    }
                }
            }
            var bestdiff = int.MaxValue;
            var bestTime = string.Empty;
            foreach (var com in comb)
            {
                if (IsValid(com))
                {
                    var diff = diffInMinute(time, com);
                    if (diff < bestdiff)
                    {
                        bestdiff = diff;
                        bestTime = com;
                    }
                }
            }
            if (string.IsNullOrEmpty(bestTime))
                return time;
            return $"{bestTime[0]}{bestTime[1]}:{bestTime[2]}{bestTime[3]}";
        }

        bool IsValid(string time)
        {
            var h = int.Parse($"{time[0]}{time[1]}");
            if (h >= 0 && h <= 23)
            {
                var m = int.Parse($"{time[2]}{time[3]}");
                if (m >= 0 && m < 60)
                    return true;
                else
                    return false;
            }
            else
                return false;
        }

        int diffInMinute(string time, string com)
        {
            var t = TimeSpan.Parse(time);
            var i = TimeSpan.Parse($"{com[0]}{com[1]}:{com[2]}{com[3]}");
            if (t == i)
                return int.MaxValue;
            var diff = i.Subtract(t);
            if (diff.TotalMinutes < 0)
            {
                var today = DateTime.Parse(t.ToString());
                var comDay = DateTime.Parse(i.ToString()).AddDays(1);
                diff = comDay.Subtract(today);
            }
            return (int)diff.TotalMinutes;
        }

    }
}
