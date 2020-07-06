using System;
using System.Collections.Generic;
using System.Text;

namespace DemoConsole.InterviewBits
{
    public class _3SumZero
    {
        public List<List<int>> threeSum(List<int> Arr)
        {
            if (Arr == null || Arr.Count == 0 || Arr.Count <= 2)
                return null;

            var A = Arr.ToArray();
            Array.Sort(A);


            var ansList = new List<List<int>>();

            var dict = new HashSet<string>();

            int n = A.Length;
            for (int i = 0; i < n; i++)
            {
                for (int j = i + 1; j < n; j++)
                {
                    for (int k = j + 1; k < n; k++)
                    {
                        if ((A[i] + A[j] + A[k]) == 0)
                        {

                            string key = A[i].ToString() + A[j].ToString() + A[k].ToString();
                            if (!dict.Contains(key))
                            {
                                ansList.Add(new List<int>() { A[i], A[j], A[k] });
                                dict.Add(key);
                            }
                        }
                    }
                }
            }

            return ansList;
        }
    }

}
