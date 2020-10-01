using System;

namespace DemoConsole.Gs{

    public class StudentElection
    {
        public int WhoIsElected(int n , int k)
        {
            if(1 == n)
                return 1;
            return (WhoIsElected(n -1, k) + k-1) % n + 1;
        }
    }
}