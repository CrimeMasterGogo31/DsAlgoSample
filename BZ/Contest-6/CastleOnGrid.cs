//using System.CodeDom.Compiler;
//using System.Collections.Generic;
//using System.Collections;
//using System.ComponentModel;
//using System.Diagnostics.CodeAnalysis;
//using System.Globalization;
//using System.IO;
//using System.Linq;
//using System.Reflection;
//using System.Runtime.Serialization;
//using System.Text.RegularExpressions;
//using System.Text;
//using System;

//class Solution26
//{

//    // Complete the minimumMoves function below.
//    static int minimumMoves(string[] grid, int startX, int startY, int goalx, int goaly)
//    {
//        Queue<string> q = new Queue<string>();
//        q.Enqueue(startX + " " + startY);
//        grid[startX][startY]='6';

//        while (q.Count > 0)
//        {
//            var cur = q.Dequeue();
//            var x = cur.Split(' ')[0];
//            var y = cur.Split(' ')[1];
//            var count = grid[x][y];

//            var yleft = y;
//            while (yleft-- >= 0)
//            {
//                if (x == goalx && yleft == goaly)
//                    return count + 1;
//                if (grid[x][yleft] == '.')
//                {
//                    grid[x][yleft] = count + 1;
//                    q.Enqueue(x + " " + yleft);
//                }
//                else
//                    break;
//            }

//            var yright = y;
//            while (yright++ < grid[0].Length)
//            {
//                if (x == goalx && yright == goaly)
//                    return count + 1;
//                if (grid[x][yright] == '.')
//                {
//                    grid[x][yright] = count + 1;
//                    q.Enqueue(x + " " + yright);
//                }
//                else
//                    break;
//            }

//            var xUp = x;
//            while (xUp-- >= 0)
//            {
//                if (xUp == goalx && y == goaly)
//                    return count + 1;
//                if (grid[xUp][y] == '.')
//                {
//                    grid[xUp][y] = count + 1;
//                    q.Enqueue(xUp + " " + y);
//                }
//                else
//                    break;
//            }

//            var xDown = x;
//            while (xDown++ < grid.Length)
//            {
//                if (xDown == goalx && y == goaly)
//                    return count + 1;
//                if (grid[xDown][y] == '.')
//                {
//                    grid[xDown][y] = count + 1;
//                    q.Enqueue(xDown + " " + y);
//                }
//                else
//                    break;
//            }

//        }


//    }


//    static void Main(string[] args)
//    {
//        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

//        int n = Convert.ToInt32(Console.ReadLine());

//        string[] grid = new string[n];

//        for (int i = 0; i < n; i++)
//        {
//            string gridItem = Console.ReadLine();
//            grid[i] = gridItem;
//        }

//        string[] startXStartY = Console.ReadLine().Split(' ');

//        int startX = Convert.ToInt32(startXStartY[0]);

//        int startY = Convert.ToInt32(startXStartY[1]);

//        int goalX = Convert.ToInt32(startXStartY[2]);

//        int goalY = Convert.ToInt32(startXStartY[3]);

//        int result = minimumMoves(grid, startX, startY, goalX, goalY);

//        textWriter.WriteLine(result);

//        textWriter.Flush();
//        textWriter.Close();
//    }
//}
