using System;
using System.Collections.Generic;
using System.Text;

namespace DemoConsole.LeetCode
{
    public class Maze
    {
        Dictionary<string, int[]> dirDict;
        HashSet<string> set;
        public bool HasPath(int[][] maze, int[] start, int[] destination)
        {
            FillDict();
            set = new HashSet<string>();
            var result = false;
            foreach (var kv in dirDict)
            {
                if (!IsNextBlocked(maze, start[0] , start[1], kv.Key))
                {
                    set.Add($"{start[0] + kv.Value[0]}-{start[1] + kv.Value[1]}-{kv.Key}");
                    result = HasPath(maze, start[0] + kv.Value[0], start[1] + kv.Value[1], kv.Key, destination);
                }

                if (result)
                    return true;
            }
            return false;
        }



        bool HasPath(int[][] maze, int indx, int indy, string dir, int[] destination)
        {
            if (IsNextBlocked(maze, indx, indy, dir))
            {
                if (indx == destination[0] && indy == destination[1])
                    return true;

                var result = false;
                foreach (var kv in dirDict)
                {
                    if (kv.Key == dir)
                        continue;

                    if (!IsNextBlocked(maze, indx , indy, kv.Key) &&
                      !set.Contains($"{indx + kv.Value[0]}-{indy + kv.Value[1]}-{kv.Key}"))
                    {
                        set.Add($"{indx + kv.Value[0]}-{indy + kv.Value[1]}-{kv.Key}");
                        result = result || HasPath(maze, indx + kv.Value[0], indy + kv.Value[1], kv.Key, destination);
                    }

                    if (result)
                        break;
                }
                return result;
            }
            else
            {
                set.Add($"{indx + dirDict[dir][0]}-{indy + dirDict[dir][1]}-{dir}");
                return HasPath(maze, indx + dirDict[dir][0], indy + dirDict[dir][1], dir, destination);
            }
        }

        bool IsNextBlocked(int[][] maze, int x, int y, string dir)
        {
            var direction = dirDict[dir];
            var nextx = x + direction[0];
            var nexty = y + direction[1];
            if (nextx >= maze.Length || nextx < 0 || nexty >= maze[0].Length || nexty < 0)
                return true;
            if (maze[nextx][nexty] == 1)
                return true;
            return false;

        }


        void FillDict()
        {
            dirDict = new Dictionary<string, int[]>();
            dirDict.Add("r", new int[2] { 0, 1 });
            dirDict.Add("d", new int[2] { 1, 0 });
            dirDict.Add("l", new int[2] { 0, -1 });
            dirDict.Add("u", new int[2] { -1, 0 });

        }
    }
}
