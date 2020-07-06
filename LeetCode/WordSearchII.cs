using System;
using System.Collections.Generic;
using System.Text;

namespace DemoConsole.LeetCode
{
    public class WordSearchII
    {
        static bool iscurrentFound;
        public IList<string> FindWords(char[][] board, string[] words)
        {
            int r = board.Length;
            int c = board[0].Length;
            var res = new List<string>();
            foreach (var word in words)
            {
                iscurrentFound = false;
                for (int i = 0; i < r; i++)
                {
                    if (iscurrentFound)
                        break;
                    for (int j = 0; j < c; j++)
                    {
                        if (iscurrentFound)
                            break;
                        if (board[i][j] == (word[0]))
                        {
                            var set = new HashSet<string>();
                            set.Add($"{i}{j}");
                            Search(board, r, c, i, j, word, 0, set);

                        }
                    }
                }

                if (iscurrentFound)
                {
                    res.Add(word);
                }
            }
            return res;
        }

        private bool Search(char[][] board, int r, int c, int i, int j, string word, int index, HashSet<string> set)
        {
            if (index + 1 == word.Length)
            {
                iscurrentFound = true;
                return true;
            }
            string key = string.Empty;
            bool top = false, bottom = false, left = false, right = false;

            key = $"{i - 1}{j}";
            if (i - 1 >= 0 && board[i - 1][j] == word[index + 1] && !iscurrentFound && !set.Contains(key))
            {
                set.Add(key);
                top = Search(board, r, c, i - 1, j, word, index + 1, set);
                set.Remove(key);
            }
            key = $"{i + 1}{j}";
            if (i + 1 < r && board[i + 1][j] == word[index + 1] && !iscurrentFound && !set.Contains(key))
            {
                set.Add(key);
                bottom = Search(board, r, c, i + 1, j, word, index + 1, set);
                set.Remove(key);

            }
            key = $"{i}{j - 1}";
            if (j - 1 >= 0 && board[i][j - 1] == word[index + 1] && !iscurrentFound && !set.Contains(key))
            {
                set.Add(key);
                left = Search(board, r, c, i, j - 1, word, index + 1, set);
                set.Remove(key);
            }
            key = $"{i}{j + 1}";
            if (j + 1 < c && board[i][j + 1] == word[index + 1] && !iscurrentFound && !set.Contains(key))
            {
                set.Add(key);
                right = Search(board, r, c, i, j + 1, word, index + 1, set);
                set.Remove(key);
            }
            return iscurrentFound || top || bottom || left || right;
        }
    }
}
