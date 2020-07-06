using System;
using System.Collections.Generic;
using System.Text;

namespace DemoConsole.BZ.Contest_3
{
    class SherlockAndArray
    {
        static string balancedSums(List<int> arr)
        {
            if (arr.Count == 1)
                return "YES";
            var la = new int[arr.Count];
            var ra = new int[arr.Count];
            la[0] = 0;
            for (int i = 1; i < arr.Count; i++)
            {
                la[i] = la[i - 1] + arr[i - 1];
            }
            ra[arr.Count - 1] = 0;
            for (int i = arr.Count - 2; i >= 0; i--)
            {
                ra[i] = ra[i + 1] + arr[i + 1];
                if (ra[i] == la[i])
                    return "YES";
            }
            return "NO";
        }
    }
}
