using System;
using System.Collections.Generic;
using System.Text;

namespace DemoConsole.LeetCode
{
    public class MaxSlidingWindowLC
    {
        public int[] MaxSlidingWindow(int[] nums, int k)
        {
            //var pq = new PriorityQueue<int>();
            var dequeue = new LinkedList<int>();

            var res = new int[nums.Length - k + 1];

            for (int i = 0; i < k; i++)
            {
                if (dequeue.Count == 0 || nums[i] < nums[dequeue.Last.Value])
                {
                    dequeue.AddLast(i);
                }
                else
                {
                    while (dequeue.Count > 0 && nums[dequeue.Last.Value] < nums[i])
                        dequeue.RemoveLast();

                    dequeue.AddLast(i);
                }
                
            }

            res[0] = nums[dequeue.First.Value];
            if (dequeue.First.Value == 0)
            {
                dequeue.RemoveFirst();
            }

            for (int i = k; i < nums.Length; i++)
            {
                if (dequeue.Count == 0 || nums[i] < nums[dequeue.Last.Value])
                {
                    dequeue.AddLast(i);
                }
                else
                {
                    while (dequeue.Count > 0 && nums[dequeue.Last.Value] < nums[i])
                        dequeue.RemoveLast();

                    dequeue.AddLast(i);
                }

                res[i - k + 1] = nums[dequeue.First.Value];

                if (dequeue.First.Value == i + k - 1)
                    dequeue.RemoveFirst();

            }

            return res;
        }

    }
}
