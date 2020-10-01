using System;

namespace DemoConsole.Gs{
    public class SecondSmallest
    {
        public int FindSecondSmallest(int[] nums)
        {
            if(nums == null || nums.Length < 2)
                return 0;

            int min = int.MaxValue-1, secondmin = int.MaxValue;
            foreach(var num in nums) //-1, 0, 1, -2, 2  m =-2 s =-1 
            {
                if(num < min)
                {
                    secondmin = min;
                    min = num;
                }
                else if(num < secondmin)
                {
                    secondmin = num;
                } 

            }
            return secondmin;
        }
    }
}