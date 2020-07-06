using System;
using System.Collections.Generic;
using System.Text;

namespace DemoConsole.LeetCode
{
    public class PathInGrid
    {
        Dictionary<int, List<char>> dict = new Dictionary<int, List<char>>();
        Dictionary<char, char> path = new Dictionary<char, char>();
        public bool HasValidPath(int[][] grid)
        {
            Fill();
            path.Add('l', 'r');
            path.Add('r', 'l');
            path.Add('t', 'b');
            path.Add('b', 't');

            if (grid == null || grid.Length == 0)
                return false;


            if (grid.Length == 1 && grid[0].Length == 1)
                return true;
            var val = grid[0][0];

            if (val == 1 || val == 6)
                return Helper(0, 1, grid, 'l');
            if (val == 2 || val == 3)
                return Helper(1, 0, grid, 't');

            if (val == 4)
                return Helper(1, 0, grid, 't') || Helper(0, 1, grid, 'l');

            return false;
        }

        bool Helper(int i, int j, int[][] grid, char entry)
        {
            if (i < 0 || i >= grid.Length || j < 0 || j >= grid[0].Length)
            {
                return false;
            }



            var val = grid[i][j];
            var p = dict[val];

            if (entry == p[0])
            {
                if (i == grid.Length - 1 && j == grid[0].Length - 1)
                    return true;
                switch (p[1])
                {
                    case 'l':
                        return Helper(i, j - 1, grid, path[p[1]]);
                    case 'r':
                        return Helper(i, j + 1, grid, path[p[1]]);
                    case 't':
                        return Helper(i - 1, j, grid, path[p[1]]);
                    case 'b':
                        return Helper(i + 1, j, grid, path[p[1]]);

                }
            }

            if (entry == p[1])
            {
                if (i == grid.Length - 1 && j == grid[0].Length - 1)
                    return true;

                switch (p[0])
                {
                    case 'l':
                        return Helper(i, j - 1, grid, path[p[0]]);
                    case 'r':
                        return Helper(i, j + 1, grid, path[p[0]]);
                    case 't':
                        return Helper(i - 1, j, grid, path[p[0]]);
                    case 'b':
                        return Helper(i + 1, j, grid, path[p[0]]);

                }
            }

            return false;

        }

        void Fill()
        {
            this.dict.Add(1, new List<char>() { 'l', 'r' });
            this.dict.Add(2, new List<char>() { 't', 'b' });
            this.dict.Add(3, new List<char>() { 'l', 'b' });
            this.dict.Add(4, new List<char>() { 'r', 'b' });
            this.dict.Add(5, new List<char>() { 'l', 't' });
            this.dict.Add(6, new List<char>() { 'r', 't' });

        }
    }

}
