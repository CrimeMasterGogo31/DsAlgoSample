//using System;
//using System.Collections.Generic;
//using System.Text;

//namespace DemoConsole.CodeForces
//{
//    class ProductOfThreeIntegers
//    {
//        public static void Main()
//        {
//            int t = Convert.ToInt32(Console.ReadLine().Trim());
//            while (t-- != 0)
//            {
//                long n = Convert.ToInt64(Console.ReadLine().Trim());
//                var isPossible = false;
//                HashSet<long> set = new HashSet<long>();

//                for (int i = 2; i * i < n; i++)
//                {
//                    if (n % i == 0 && !set.Contains(i))
//                    {
//                        set.Add(i);
//                        n = n / i;
//                    }
//                    if (set.Count == 2 && !set.Contains(n))
//                    {
//                        isPossible = true;
//                        break;
//                    }
//                    if (set.Count == 2 && set.Contains(n))
//                        break;
//                }
//                var printval = isPossible ? "YES" : "NO";
//                Console.WriteLine(printval);
//                if (isPossible)
//                {
//                    foreach (var s in set)
//                        Console.Write(s + " ");
//                    Console.Write(n);
//                    Console.WriteLine();
//                }
//            }
//        }
//    }
//}
