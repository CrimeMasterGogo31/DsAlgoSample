using System;
using System.Collections.Generic;
using System.Text;

namespace DemoConsole.LeetCode
{
    // Dynamic Programing
    // Bottom Up
    // TC O(M*N)
    // SP O(M*N)
    public class UniquePathsClass
    {
        int total;
        public int UniquePathsIII(int[][] grid) {
            total =0;
            var walkablepath = 0;
            var r = grid.Length;
            var c = grid[0].Length;
            int startx=0, starty=0;
            
            for(int i =0; i < r; i++)
            {
                for(int j =0; j< c; j++)
                {
                    if(grid[i][j] == 0)
                        walkablepath++;
                    else if(grid[i][j] == 1)
                    {
                        startx =i; 
                        starty =j;
                    }
                }
            }
            var key = $"{startx},{starty}";
            var set = new HashSet<string>();
            set.Add(key);
            Traverse(grid, startx, starty, set, walkablepath);
            return total;
        }
        
        void Traverse(int[][] grid, int indx,int indy, HashSet<string> set, int walkablepath)
        {
            
            var r = grid.Length;
            var c = grid[0].Length;
            
            if(indx< 0 || indx>= r || indy <0 || indy >= c)
                return;
            if(grid[indx][indy] == -1)
                return;
            if(grid[indx][indy] == 2)
            {
                if(set.Count == walkablepath + 2)
                {
                    total++;
                    Console.WriteLine(total);
                }
                return;
            }
            
            
            var key = $"{indx-1},{indy}";
            if(!set.Contains(key))
            {
                set.Add(key);
                Traverse(grid, indx-1, indy, set, walkablepath);
                set.Remove(key);
            }
            
            key = $"{indx},{indy+1}";
            if(!set.Contains(key))
            {
                set.Add(key);
                Traverse(grid, indx, indy+1, set, walkablepath);
                set.Remove(key);
            }
            
            key = $"{indx+1},{indy}";
            if(!set.Contains(key))
            {
                set.Add(key);
                Traverse(grid, indx+1, indy, set, walkablepath);
                set.Remove(key);
            }    
            
            key = $"{indx},{indy-1}";
            if(!set.Contains(key))
            {
                set.Add(key);
                Traverse(grid, indx, indy-1, set, walkablepath);
                set.Remove(key);
            }
                        
        }
    }
}