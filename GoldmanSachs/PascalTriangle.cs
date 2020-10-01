using System;

namespace DemoConsole.Gs
{
    public class PascalTriangleClass{
        public int Pascal (int col, int row)
        {
            var arrprev = new int[] {1, 1};

            if(row < 0 || col < 0 || row < col)
                return -1; // handle invalid case
            
            if(row == 0 && col ==0)
                return 1;

            if(row ==1)
                return arrprev[col];
            int i = 2;
            while(i <= row)
            {
                var arr = new int[i +1];
                arr[0] = 1;
                for(int c =1; c < i ; c++ )
                {
                    arr[c] = arrprev[c-1] + arrprev[c]; 
                }
                arr[i] = 1;
                arrprev = arr;
                i++;
            } 
            return arrprev[col];

        }
    }
}