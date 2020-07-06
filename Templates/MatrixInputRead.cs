//using System;

//class MatrixInputRead
//{
//    static int[,] m;

//    static void Main(String[] args)
//    {
//        var input = Console.ReadLine().Split(" ");
//        var r = Convert.ToInt32(input[0]);
//        var c = Convert.ToInt32(input[1]);
//        m = new int[r, c];
//        for (int i = 0; i < r; i++)
//        {
//            var rows = Array.ConvertAll(Console.ReadLine().Trim().Split(' '), wTemp => Convert.ToInt32(wTemp));
//            for (int j = 0; j < c; j++)
//            {
//                m[i, j] = rows[j];
//            }
//        }
//    }
//}
