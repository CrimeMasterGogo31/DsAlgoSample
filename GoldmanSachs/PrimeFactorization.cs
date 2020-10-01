using System;
using System.Collections.Generic;

namespace DemoConsole.Gs
{
    public class PrimeFactorizationClass
    {
        // Poptimized code
        public List<int> PrimeFactorizationGFG(int x)
        {
            var result = new List<int>();
            while(x % 2 == 0)
            {
                result.Add(2);
                x /= 2;
            }
            var sqrt = Math.Sqrt(x);
            int i = 3;
            while(i <= sqrt)
            {
                if( x % i == 0)
                {
                    result.Add(i);
                    x /= i;
                }
                else
                {
                    i += 2;
                }
            }

            if(x > 2)
                result.Add(x);
            
            return result;
        }


        List<int> primeList = new List<int>();
        public List<int> PrimeFactorization(int x)  // 1 [2,3,5,7,9, 11]   {3, 5} check GFG  first divide with 2 and then wil all odd numbers
        {
            Fill(x);
            var result = new List<int>();
            while(x > 1)
            {
                foreach(var prime in primeList)
                {
                    if(0 == x % prime)
                    {
                        x /= prime;
                        result.Add(prime);
                        break;
                    }
                }
                break;
            }
            
            if(0 == result.Count)
            {
                result.Add(x);
            }
            return result;
        }

        void Fill(int num)
        {
            var primearr = new bool[num+1];

            for(int i =2; i <= num ; i++)
                primearr[i] = true;

            for(int i =2 ; i * 2 <= num; i++)
            {
                if(!primearr[i] || !IsPrime(i))
                {
                    // mask all multiple as false
                    for(int j =i ; j <= num ; j+=i )
                    {
                        primearr[i] = false;
                    }
                }
                else
                {
                    primeList.Add(i);
                }
            }
        }

        bool IsPrime(int num)
        {
            for(int i =2 ; i*i <= num; i++)
            {
                if(0 == num % i)
                    return false;
            }

            return true;
        }
    }
}