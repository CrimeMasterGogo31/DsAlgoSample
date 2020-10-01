using System;
using System.Collections.Generic;
using System.Text;

namespace DemoConsole.Gs
{
    public class PowerOfTenClass
    {
        // TC = O(LogN) 
       public bool isIPowerOf10( int num ) // 1/10  0.1
        {
            if(num <= 0)
                return false;
            while(num>9)
            {
                if(num % 10 == 0)
                    num/= 10;
                else 
                    return false;
            }       
            return num <= 1 ? true: false;     
        }  

        // TC: O(1)
        public bool isIPowerOfTen( int num ) // 1/10  0.1
        {
            if(num <= 0)
                return false;
            int logval = Convert.ToInt32(Math.Log(num)/ Math.Log(10));    
            return Convert.ToInt32(Math.Pow(10, logval)) == num ? true: false;     
        }  
    }
}


