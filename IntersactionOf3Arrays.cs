using System;
using System.Collections.Generic;
using System.Text;

namespace DemoConsole
{
    //Google -- FInd InterscationElement in 3  sorted array 
    // O(n)
    public class IntersactionOf3ArraysClass
    {
        public int[] IntersactionOf3Arrays(int[] a, int[] b, int[] c)
        {
            int len_a = a.Length;
            int len_b = b.Length;
            int len_c = c.Length;
            int x = 0; int y = 0; int z = 0;
            List<int> matched_array= new List<int>();
          //  int currentMatch = 0;
            while (x < len_a && y < len_b && z < len_c)
            {
                if ((a[x] == b[y]) &&( a[x]==c[z]))
                {
                    matched_array.Add(a[x]);
                    x++;y++;z++;
                    continue;
                }else if(Math.Min(a[x], Math.Min(b[y], c[z])) == a[x])
                    x++;
                else if (Math.Min(a[x], Math.Min(b[y], c[z])) == b[y])
                    y++;
                else if(Math.Min(a[x], Math.Min(b[y], c[z])) == c[z])
                    z++;
            }
            return matched_array.ToArray();
        }
    }
}
