using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DemoConsole.LeetCode
{
    public class CanFinishCourse
    {
        public bool CanFinish(int numCourses, int[][] prerequisites)
        {
            // map of courses which have this course as a prereq
            List<int>[] list = new List<int>[numCourses];
            for (int i = 0; i < numCourses; i++) list[i] = new List<int>();

            // counter of how many prereqs for a course
            int[] counter = new int[numCourses];

            // build map and counter
            for (int i = 0; i < prerequisites.GetLength(0); i++)
            {
                int course = prerequisites[i][ 0];
                int pre = prerequisites[i][ 1];
                list[pre].Add(course);
                counter[course]++;
            }

            // BFS - start will all courses with no prereqs
            // process each item
            //   - any dependent course that has no prereqs - this is a cycle
            //   - if removing this prereq brings it's count to zero - add this course for processing
            Queue<int> queue = new Queue<int>();
            for (int i = 0; i < numCourses; i++) if (counter[i] == 0) queue.Enqueue(i);

            while (queue.Count > 0)
            {
                int pre = queue.Dequeue();
                foreach (int c in list[pre])
                {
                    if (counter[c] == 0) return false;
                    counter[c]--;
                    if (counter[c] == 0) queue.Enqueue(c);
                }
            }

            // all prereqs removed?
            return counter.All(x => x == 0);
        }

        //public bool CanFinish(int numCourses, int[][] pre)
        //{

        //    for (int i = 0; i < pre.Length; i += 2)
        //    {
        //        Stack<int> stk = new Stack<int>();

        //        stk.Push(pre[i / 2][ 0]);
        //        stk.Push(pre[i / 2][ 1]);

        //        for (int j = 0; j < pre.Length; j += 2)
        //        {
        //            if (j == i)
        //                continue;

        //            if (stk.Peek() == pre[j / 2][ 0])
        //            {
        //                stk.Pop();
        //                stk.Push(pre[j / 2][ 1]);
        //            }
        //        }

        //        int last = stk.Pop();
        //        int first = stk.Pop();
        //        if (last == first)
        //        {
        //            return false;
        //        }
        //    }

        //    return true;
        //}
    }
}
