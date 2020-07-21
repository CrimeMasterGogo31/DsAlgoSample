using System;
using System.Collections.Generic;
using System.Text;

namespace DemoConsole.LeetCode
{
    // https://leetcode.com/problems/word-search/
    public class SolutionWordSearch
    {
        public bool Exist(char[][] board, string word)
        {
            for (int i = 0; i < board.Length; i++)
            {
                for (int j = 0; j < board[0].Length; j++)
                {
                    if (Isvalid(board, i, j, 0, word, new HashSet<string>()))
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        bool Isvalid(char[][] board, int i, int j, int wordIndex, string word, HashSet<string> set)
        {
            if (i < 0 || i >= board.Length || j < 0 || j >= board[0].Length)
            {
                return false;
            }
            var key = $"{i}#{j}";
            if (set.Contains(key))
                return false;

            if (board[i][j] != word[wordIndex])
            {
                return false;
            }
            else
            {
                if (wordIndex == word.Length - 1)
                    return true;

                set.Add(key);

                var res = Isvalid(board, i + 1, j, wordIndex + 1, word, set) ||
                Isvalid(board, i, j + 1, wordIndex + 1, word, set) ||
                Isvalid(board, i - 1, j, wordIndex + 1, word, set) ||
                Isvalid(board, i, j - 1, wordIndex + 1, word, set);
                set.Remove(key);

                return res;

            }

        }
    }
}
