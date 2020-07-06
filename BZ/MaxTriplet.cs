using System;
using System.Collections.Generic;
using System.Text;

namespace DemoConsole.BeingZero
{
   public class MaxTriplet
    {
        public int maxTripletProduct(List<int> al)
        {
            int res = 1;
            int fmax = int.MinValue, smax = int.MinValue, tmax = int.MinValue;
            int fmin = int.MaxValue, smin = int.MaxValue;
            if (al.Count <= 3)
            {
                for (int i = 0; i < al.Count; i++)
                {
                    res *= al[i];
                }
            }
            else
            {
                for (int i = 0; i < al.Count; i++)
                {
                    if (al[i] >= fmax)
                    {
                        tmax = smax;
                        smax = fmax;
                        fmax = al[i];
                    }
                    else if (al[i] >= smax)
                    {
                        tmax = smax;
                        smax = al[i];
                    }
                    else if (al[i] > tmax)
                    {
                        tmax = al[i];
                    }
                    if (al[i] <= fmin)
                    {
                        smin = fmin;
                        fmin = al[i];

                    }
                    else if (al[i] < smin)
                    {
                        smin = al[i];
                    }
                }
            }
            res = Math.Max(fmax * smax * tmax , fmin * smin * fmax);
            return res;
        }
}
}
