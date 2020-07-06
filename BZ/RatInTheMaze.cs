using System;
using System.Collections.Generic;

class BeingZeroRMZ
{
    static int[,] m;
    static int r;
    static int c;
    static int[] dirx = new int[] { 1, 0, 0, -1 };//d l r u
    static int[] diry = new int[] { 0, -1, 1, 0 };
    static string[] dir = new string[] { "D", "L", "R", "U" };
    static List<string> path;
    static List<string> visited;

    //public static void Main(string[] args)
    //{
    //    var t = Convert.ToInt32(Console.ReadLine());
    //    while (t-- != 0)
    //    {
    //        var input = Console.ReadLine().Split(" ");
    //        r = Convert.ToInt32(input[0]);
    //        c = Convert.ToInt32(input[1]);
    //        m = new int[r, c];
    //        for (int i = 0; i < r; i++)
    //        {
    //            var rows = Array.ConvertAll(Console.ReadLine().Trim().Split(' '), wTemp => Convert.ToInt32(wTemp));
    //            for (int j = 0; j < c; j++)
    //            {
    //                m[i, j] = rows[j];
    //            }
    //        }
    //        path = new List<string>();
    //        visited = new List<string>();
    //        FindPath(0, 0);
    //        Console.WriteLine();
    //    }
    //}

    static void FindPath(int x, int y)
    {
        if (x == r - 1 && y == c - 1)
        {
            PrintPath(path);
            return;
        }
        if (x < 0 || y < 0 || x >= r || y >= c)
            return;

        if (m[x, y] == 0)
            return;
        if (visited.Contains($"{x}{y}"))
            return;
        visited.Add($"{x}{y}");
        for (int i = 0; i < 4; i++) {
            path.Add(dir[i]);
            FindPath(x + dirx[i], y + diry[i]);
            path.RemoveAt(path.Count - 1);
        }
        visited.RemoveAt(visited.Count - 1);

       
    }

    static void PrintPath(List<string> path)
    {
        foreach (var i in path)
            Console.Write(i);
        Console.Write(" ");
    }
}