using System;
using System.Collections.Generic;
using System.Text;

namespace DemoConsole.InterviewBits
{
    class MaximumHotelBookingPossible
    {

        static int maxoverlap;
        public int hotel(List<int> A, List<int> B, int C)
        {
            A.Sort();
            B.Sort();
            for (int i = 0; i < A.Count - 1; i++)
            {
                CompareOverlapping(A[i], B[i], A[i + 1], B[i + 1]);
            }
            return 1;
        }

        private void CompareOverlapping(int s1, int e1, int s2, int e2)
        {
            //if((s1>s2 && s1<e2)||(e1>s2 &&e1<))
        }
    }
}
