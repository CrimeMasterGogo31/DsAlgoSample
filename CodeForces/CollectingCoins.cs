//using System;
//using System.Collections.Generic;
//using System.Text;

//namespace DemoConsole.CodeForces
//{
//    class CollectingCoins
//    {
//        public static void Main()
//        {

//            var t = Convert.ToInt32(Console.ReadLine().Trim());
//            while (t-- != 0)
//            {
//                var arr = Array.ConvertAll(Console.ReadLine().Trim().Split(' '),
//                 tmp => Convert.ToInt64(tmp));
//                long sum = 0;
//                foreach (var num in arr)
//                {
//                    sum += num;
//                }
//                var a = arr[0];
//                var b = arr[1];
//                var c = arr[2];
//                var n = arr[3];
//                if (sum % 3 == 0)
//                {
//                    var e = sum / 3;
//                    var A = e - a;
//                    var B = e - b;
//                    var C = e - c;
//                    if (A < 0 || B < 0 || C < 0 || (A + B + C != n))
//                        Console.WriteLine("NO");
//                    else
//                        Console.WriteLine("YES");
//                }
//                else
//                    Console.WriteLine("NO");
//            }
//        }
//    }
//}
