using System;
using System.Collections.Generic;
using System.Text;

namespace DemoConsole
{
   public class Footballscore
    {
        static long length = Convert.ToInt64(Math.Pow(10, 9));
      

        public static List<int> counts(List<int> teamA, List<int> teamB)
        {
            var result = new List<int>();

            if (teamB == null || teamB.Count == 0)
                return result;

            var arra = teamA.ToArray();  //1202
            var arrb = teamB.ToArray();  //1202
            Array.Sort(arra);
            Array.Sort(arrb);
            long[] arrDict = new long[length];

            for (int i = 0; i < arra.Length; i++)
            {
                arrDict[arra[i]]++;
            }

            for (int i = 1; i <= arrb[arrb.Length-1]; i++)
            {
                arrDict[i] += arrDict[i - 1];
            }

            foreach (var b in teamB)
            {
                result.Add(Convert.ToInt32(arrDict[b]));
            }
            return result;
        }
    }
}
