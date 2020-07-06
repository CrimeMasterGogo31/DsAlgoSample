using System;
using System.Collections.Generic;
using System.Text;

namespace DemoConsole
{
    public class LargestNumber
    {
        class GFG : IComparer<int>
        {
            public int Compare(int x, int y)
            {
                if (x == 0 || y == 0)
                {
                    return 0;
                }
                int i = x;
                int countI = 0;
                int j = y;
                int countJ = 0;

                while (i >= 10) //456
                {
                    countI++;
                    i /= 10;
                }
                
                while (j >= 10)
                {
                    countJ++;
                    j /= 10;
                }
                while (i == j &(countI!=0 || countJ!=0))
                {
                    i=x-(i * (int)Math.Pow(10,countI));
                    j =y- (j * (int)Math.Pow(10,countJ));
                    while (i >= 10) //456
                    {
                        countI++;
                        i /= 10;
                    }
                    while (j >= 10)
                    {
                        countJ++;
                        j /= 10;
                    }
                }
                // CompareTo() method 
                return i.CompareTo(j);

            }
        }

        public string largestNumber(List<int> A)
        {
            GFG gg = new GFG();
            A.Sort(gg);
            A.Reverse();
            string result = "";
            foreach (var i in A)
            {
                result = result + i.ToString();
            }
            return result;
        }
    }
}
