using System;
using System.Collections.Generic;
using System.Text;

namespace DemoConsole
{
    public class MaxNonNegetiveSubArray
    {
        public List<int> maxset(List<int> A)
        {
            var result = new List<int>();
            var ArrrayList = new List<List<int>>();
            var temp = new List<int>();
            for (int index = 0; index <= A.Count; index++)
            {
                if (index >= A.Count) {
                    if (temp.Count > 0)
                    {
                        ArrrayList.Add(temp);
                    }
                    break;

                }
                if (A[index] >= 0)
                {
                    temp.Add(A[index]);
                }
                else {
                    if (temp.Count > 0)
                    {
                        ArrrayList.Add(temp);
                        temp = new List<int>();
                    }
                  
                }
            }
            var prev = new List<int>(); 
            var current = new List<int>();

            foreach (var list in ArrrayList) {
                prev = result;
                current = list;
                result= ComapareArrays(prev, current);
            }

            return result;
        }

        private List<int> ComapareArrays(List<int> old, List<int> latest)
        {
            if (SumOfArray(old) > SumOfArray(latest))
            {
                return old;
            }
            else if (SumOfArray(old) < SumOfArray(latest))
            {
                return latest;
            }
            else if (SumOfArray(old) == SumOfArray(latest))
            {
                if (old.Count > latest.Count)
                {
                    return old;
                }
                else if (old.Count < latest.Count)
                {
                    return latest;
                }
                else
                {
                    return old;
                }
            }
            else
            {
                return old;
            }



        }

        private long SumOfArray(List<int> arr)
        {
            long sum = 0;
            foreach (var i in arr)
            {
                sum += i;
            }
            return sum;
        }
    }
}
