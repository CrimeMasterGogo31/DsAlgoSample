using System;
using System.Collections.Generic;
using System.Text;

namespace DemoConsole.LeetCode
{
    class TimeNeededtoInformAllEmployees
    {
        public int NumOfMinutes(int n, int headID, int[] manager, int[] informTime)
        {
            int totalTime = 0;
            var dict = new Dictionary<int, List<int>>();
            for (int i = 0; i < manager.Length; i++)
            {
                if (i != headID)
                {
                    if (dict.ContainsKey(manager[i]))
                    {
                        dict[manager[i]].Add(i);
                    }
                    else
                    {
                        dict.Add(manager[i], new List<int>() { i });
                    }
                }
            }
            var cur = headID;
            var eList = dict[cur];
            var nodeTime = 0;
            foreach (var e in eList)
            {
                var iTime = 0;
                if (dict.ContainsKey(e))
                {
                    iTime = informTime[e] + CalculateTIme(e, dict, informTime);
                }
                nodeTime = Math.Max(iTime, nodeTime);
            }

            return totalTime;
        }

        int CalculateTIme(int empId, Dictionary<int, List<int>> dict, int[] informTime)
        {
            if (!dict.ContainsKey(empId))
                return 0;
            var eList = dict[empId];
            var nodeTime = 0;
            foreach (var e in eList)
            {
                var iTime = 0;
                if (dict.ContainsKey(e))
                {
                    iTime = informTime[e] + CalculateTIme(e, dict, informTime);
                }
                nodeTime = Math.Max(iTime, nodeTime);
            }
            return nodeTime;

        }
    }
}
