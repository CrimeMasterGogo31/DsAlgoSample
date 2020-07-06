using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;

//class Solution
//{

//    // Complete the minimumMoves function below.
//    static int minimumMoves(string[] grid, int startX, int startY, int goalx, int goaly)
//    {
//        int cost = 1;
//        int l = int.MaxValue, r = int.MaxValue, u = int.MaxValue, d = int.MaxValue;

//        l = helper(grid, startX, startY - 1, goalx, goaly, cost, 1);
//        r = helper(grid, startX, startY + 1, goalx, goaly, cost, 2);
//        u = helper(grid, startX - 1, startY, goalx, goaly, cost, 3);
//        d = helper(grid, startX + 1, startY, goalx, goaly, cost, 4);

//        return Math.Min(l, Math.Min(r, Math.Min(u, d)));

//    }
//    static int helper(string[] grid, int curx, int cury, int goalx, int goaly,int cost, int dir)
//    {
//        if (curx < 0 || curx >= grid.Length || cury < 0 || cury >= grid[0].Length)
//            return int.MaxValue;
//        if (grid[curx][cury] == 'X')
//            return int.MaxValue;

//        if (curx == goalx && cury == goaly)
//            return cost;
//        int l = int.MaxValue, r = int.MaxValue, u = int.MaxValue, d = int.MaxValue;
//        switch (dir)
//        {
//            case 1:
//                l = helper(grid, curx, cury - 1, goalx, goaly, cost, 1);
//                r = helper(grid, curx, cury + 1, goalx, goaly, cost++, 2);
//                u = helper(grid, curx - 1, cury, goalx, goaly, cost++, 3);
//                d = helper(grid, curx + 1, cury, goalx, goaly, cost++, 4);

//                break;
//            case 2:
//                r = helper(grid, curx, cury + 1, goalx, goaly, cost, 2);
//                l = helper(grid, curx, cury - 1, goalx, goaly, cost++, 1);
//                u = helper(grid, curx - 1, cury, goalx, goaly, cost++, 3);
//                d = helper(grid, curx + 1, cury, goalx, goaly, cost++, 4);

//                break;
//            case 3:
//                l = helper(grid, curx, cury - 1, goalx, goaly, cost++, 1);
//                r = helper(grid, curx, cury + 1, goalx, goaly, cost++, 2);
//                u = helper(grid, curx - 1, cury, goalx, goaly, cost, 3);
//                d = helper(grid, curx + 1, cury, goalx, goaly, cost++, 4);
//                break;
//            case 4:
//                d = helper(grid, curx + 1, cury, goalx, goaly, cost, 4);
//                l = helper(grid, curx, cury - 1, goalx, goaly, cost++, 1);
//                r = helper(grid, curx, cury + 1, goalx, goaly, cost++, 2);
//                u = helper(grid, curx - 1, cury, goalx, goaly, cost++, 3);
//                break;

//        }
//        return Math.Min(l, Math.Min(r, Math.Min(u, d)));
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
