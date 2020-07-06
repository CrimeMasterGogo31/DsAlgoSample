using System;
using System.Collections.Generic;
using System.Text;

namespace DemoConsole.CodeForces
{
    class CollectingPackages
    {
        static int max_x = 0;
        static int max_y = 0;
        static int totalP;
        static HashSet<string> packages;
        static SortedSet<string> sortedPaths;
        //public static void Main()
        //{

        //    var t = Convert.ToInt32(Console.ReadLine().Trim());
        //    while (t-- != 0)
        //    {
        //        var n = Convert.ToInt32(Console.ReadLine().Trim());
        //        totalP = n;
        //        max_x = 0;
        //        max_y = 0;
        //        packages = new HashSet<string>();
        //        while (n-- != 0)
        //        {
        //            var arr = Array.ConvertAll(Console.ReadLine().Trim().Split(' '),
        //         tmp => Convert.ToInt32(tmp));
        //            if (arr[0] > max_x)
        //                max_x = arr[0];
        //            if (arr[1] > max_y)
        //                max_y = arr[1];

        //            packages.Add("x" + arr[0] + "y" + arr[1]);
        //        }

        //        sortedPaths = new SortedSet<string>();
        //        string path = string.Empty;
        //        DFS(0, 0, path, totalP);
        //        if (sortedPaths.Count > 1)
        //        {
        //            Console.WriteLine("YES");
        //            foreach (var p in sortedPaths)
        //            {
        //                Console.Write(p);
        //                break;
        //            }
        //            Console.WriteLine();
        //            continue;
        //        }
        //        Console.WriteLine("NO");

        //    }
        //}

        static void DFS(int x, int y, string path, int remaining)
        {
            if (x > max_x)
                return;
            if (y > max_y)
                return;
            var key = "x" + x + "y" + y;
            if (packages.Contains(key))
                remaining--;
            if (remaining == 0)
            {
                sortedPaths.Add(path);
                return;
            }

            path += "R";
            DFS(x + 1, y, path, remaining);
            path = path.Remove(path.Length - 1);

            path += "U";
            DFS(x, y + 1, path, remaining);
            path = path.Remove(path.Length - 1);
            return;
        }
    }
}
