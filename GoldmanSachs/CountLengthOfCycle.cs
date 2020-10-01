using System;
using System.Collections.Generic;

namespace DemoConsole.Gs{

    public class CountLengthOfCycle
    {
        public int CountLength(int[] arr, int startIndex)
        {
            if(startIndex < 0)
                return -1;

            var stack = new Stack<int>();
            int i = startIndex;
            while(i < arr.Length && i >=0) // 1, 2,0  stack : 0 , 1 , 2 dict   0: 1 , 1:2, 2: 3  use dictionary instead of stack
            {
                if(arr[i] ==-1)
                    break;

                stack.Push(i);
                var t = arr[i];
                arr[i] = -1;
                i =t;
            }

            if(i >= arr.Length)
            {
                return -1;
            }

            var cycleLen = 0;
            while(stack.Count >0)
            {
                cycleLen++;
                if(i == stack.Peek())
                    break;
                stack.Pop();
            }
            return cycleLen;

        }
    }
}