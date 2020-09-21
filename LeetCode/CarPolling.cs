using System;

namespace DemoConsole.LeetCode.CarPolling
{
    public class CarPoolingClass{
        public bool CarPooling(int[][] trips, int capacity) {
       
        var last = 0;
        foreach(var trip in trips)
        {
            last = Math.Max(last, trip[2]);
        }
        
        var dp = new int[last+1];
        
        foreach(var trip in trips)
        {
            dp[trip[1]] += trip[0];
            dp[trip[2]] -= trip[0];
        }
        
        var curoccupancy =0;
        for(int i =0; i<= last; i++)
        {
            curoccupancy += dp[i];
            dp[i] = curoccupancy;
            
            if(curoccupancy > capacity)
                return false;
        }
        
        
        return true;
        }
    }

}