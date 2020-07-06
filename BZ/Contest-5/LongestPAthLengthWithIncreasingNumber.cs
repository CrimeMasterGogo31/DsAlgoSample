using System;

class test
{
    static int r;
    static int c;
    //public static void Main()
    //{
    //    int t = Convert.ToInt32(Console.ReadLine().Trim());
    //    while (t-- != 0)
    //    {
    //        var line = Console.ReadLine().Trim().Split(' ');
    //        r = Convert.ToInt32(line[0]);
    //        if (line.Length == 1)
    //            c = 2;
    //        else
    //            c = Convert.ToInt32(line[1]);
    //        int[,] mat = new int[r, c];

    //        for (int i = 0; i < r; i++)
    //        {
    //            var rows = Array.ConvertAll(Console.ReadLine().Trim().Split(' '), w => Convert.ToInt32(w));
    //            for (int j = 0; j < c; j++)
    //            {
    //                mat[i, j] = rows[j];
    //            }
    //        }
    //        var res = FindPath(mat, 0, 0, mat[0, 0], 0);
    //        Console.WriteLine(res);
    //    }
    //}    //public static void Main()
    //{
    //    int t = Convert.ToInt32(Console.ReadLine().Trim());
    //    while (t-- != 0)
    //    {
    //        var line = Console.ReadLine().Trim().Split(' ');
    //        r = Convert.ToInt32(line[0]);
    //        if (line.Length == 1)
    //            c = 2;
    //        else
    //            c = Convert.ToInt32(line[1]);
    //        int[,] mat = new int[r, c];

    //        for (int i = 0; i < r; i++)
    //        {
    //            var rows = Array.ConvertAll(Console.ReadLine().Trim().Split(' '), w => Convert.ToInt32(w));
    //            for (int j = 0; j < c; j++)
    //            {
    //                mat[i, j] = rows[j];
    //            }
    //        }
    //        var res = FindPath(mat, 0, 0, mat[0, 0], 0);
    //        Console.WriteLine(res);
    //    }
    //}

    static int FindPath(int[,] mat, int x, int y, int val, int count)
    {
        if (x >= r || y >= c)
            return count;
        if (!(x == 0 && y == 0) && (mat[x, y] <= val))
            return count;

        count++;

        var ri = FindPath(mat, x, y + 1, mat[x, y], count);
        var down = FindPath(mat, x + 1, y, mat[x, y], count);
        return Math.Max(ri, down);

    }
}
