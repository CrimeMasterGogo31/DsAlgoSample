using System;
using System.Collections.Generic;
using System.Text;

namespace DemoConsole.BZ.Contest_2
{
    class SpecialIntegers
    {
        const int number = 1000001;
        static bool[] prime = new bool[number];
        static void Fill()
        {
            for (int i = 0; i < number; i++)
                prime[i] = true;

            for (int i = 2; i * i < number; i++)
            {
                for (int j = i * i; j < number; j += i)
                {
                    prime[j] = false;
                }
            }
        }

        private static int FindSpecial(int l, int r)
        {
            int count = 0;
            for (int i = l; i <= r; i++)
            {
                if (isPrime(i))
                {
                    var rev = Reverse(i);
                    if (rev == i)
                        continue;
                    if (isPrime(rev))
                    {
                        if (r < rev)
                            count++;
                        else if (i < rev)
                            continue;
                        else
                            count++;
                    }
                }
            }
            return count;
        }

        private static bool isPrime(int n)
        {
            return prime[n];
        }

        private static int Reverse(int n)
        {
            int temp = 0;
            while (n > 0)
            {
                temp = (temp * 10) + n % 10;
                n /= 10;
            }
            return temp;
        }

        //static void Main(String[] args)
        //{
        //    Fill();
        //    int t = Convert.ToInt32(Console.ReadLine().Trim());
        //    while (t-- != 0)
        //    {
        //        string[] vedw = Console.ReadLine().Trim().Split(' ');
        //        int l = Convert.ToInt32(vedw[0]);
        //        int r = Convert.ToInt32(vedw[1]);
        //        Console.WriteLine(FindSpecial(l, r));
        //    }
        //}
    }
}
