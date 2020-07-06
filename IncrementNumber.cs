using System;
using System.Collections.Generic;
using System.Text;

namespace DemoConsole
{
    public class IncrementNumber
    {

        public List<int> plusOne(List<int> A)  //0 0 9
        {
            var revList = new List<int>();

            for (int i = A.Count - 1; i >= 0; i--)
            {
                revList.Add(A[i]);
            }
            var carry = 10;
            for (int i = 0; i < revList.Count; i++)
            {
                if (carry == 10)
                {
                    if (revList[i] < 9)
                    {
                        revList[i] += 1;
                        carry = 0;
                    }
                    else
                    {
                        revList[i] = 0;
                        carry = 10;
                    }
                }

            }
            if (carry == 10)
            {
                revList.Add(1);
            }
            var returnList = new List<int>();
            bool toBeSkipped = true;
            for (int i = revList.Count - 1; i >= 0; i--)
            {
                if (revList[i] == 0 && toBeSkipped)
                {
                    continue;
                }
                else
                {
                    toBeSkipped = false;
                    returnList.Add(revList[i]);

                }
            }

            return returnList;
        }
    }
}
