using System;
using System.Collections.Generic;
using System.Text;

namespace DemoConsole.Gs
{
    public class DotProductClass
    {
       public long DotProduct( int[] array1, int[] array2 )
        {
            long product =0;
            int i =0;
            while(i < array1.Length || i< array2.Length)
            {
                var val1 = i < array1.Length ? array1[i] : 1;
                var val2 = i < array2.Length ? array2[i] : 1;

                product += val1 * val2;
                i++;
            }
            return product;
        }  

    }
}


