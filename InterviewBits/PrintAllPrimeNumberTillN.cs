using System;
using System.Collections.Generic;
using System.Text;

namespace DemoConsole.InterviewBits
{
   public class PrintAllPrimeNumberTillN
    {
        public List<int> sieve(int A)
        {
            List<int> list = new List<int>();
            for (int i = 0; i <= A; i++)
            {
                list.Add(i);
            }

            for (int i = 2; i <= A; i++)
            {
                if (IsPrime(i))
                    deleteMultipleOf(i, list);
                // list[list.IndexOf(i)] = 0;
            }
            //if (list.Count >= 2)
            //{
            //    list.RemoveAt(0);
            //    list.RemoveAt(1);
            //}
            List<int> res = new List<int>();

            for (int i = 2; i <= A-2; i++)
            {
                if (list[i] != 0)
                    res.Add(list[i]);
            }
            return res;

        }

        private static void deleteMultipleOf(int i, List<int> list)
        {
            int count = 2;
            while (i * count < list.Count)
            {
                list[i * count] = 0;
                count++;
            }
        }

        private static bool IsPrime(int n)
        {
            if (n == 2)
                return true;
            for (int i = 2; i < n; i++)
            {
                if (0 == n % i)
                    return false;
            }
            return true;
        }
    }
}
