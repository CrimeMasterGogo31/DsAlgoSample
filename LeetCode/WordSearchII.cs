using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DemoConsole.LeetCode.WordSearchII
{
    public class TrieNode
    {
        public TrieNode[] arr;
        public bool iseow;
        public string word;

        public TrieNode()
        {
            arr = new TrieNode[26];
        }
    }
    public class WordSearchII
    {
        public IList<string> FindWords(char[][] board, string[] words)
        {
            int r = board.Length;
            int c = board[0].Length;
            var res = new HashSet<string>();
            var root = FillTrie(words);

            for (int i = 0; i < r; i++)
            {
                for (int j = 0; j < c; j++)
                {
                    var set = new HashSet<string>();
                    set.Add($"{i}{j}");
                    Search(board, r, c, i, j, "", res, set, root);
                }
            }

            return res.ToList();
        }

        private TrieNode FillTrie(string[] words)
        {
            var root = new TrieNode();

            foreach (var word in words)
            {
                var cur = root;
                foreach (var ch in word)
                {
                    if (cur.arr[ch - 'a'] == null)
                    {
                        cur.arr[ch - 'a'] = new TrieNode();
                    }
                    cur = cur.arr[ch - 'a'];
                }
                cur.iseow = true;
                cur.word = word;
            }

            return root;
        }

        private void Search(char[][] board, int r, int c, int i, int j, string word, HashSet<string> res, HashSet<string> set, TrieNode root)
        {
            word += board[i][j];
            if (!ContainsPrefix(word, root))
            {
                return;
            }

            if (ContainsWord(word, root))
            {
                res.Add(word);
            }

            string key = string.Empty;

            key = $"{i - 1}{j}";
            if (i - 1 >= 0 && !set.Contains(key))
            {
                set.Add(key);
                Search(board, r, c, i - 1, j, word, res, set, root);
                set.Remove(key);
            }
            key = $"{i + 1}{j}";
            if (i + 1 < r && !set.Contains(key))
            {
                set.Add(key);
                Search(board, r, c, i + 1, j, word, res, set, root);
                set.Remove(key);

            }
            key = $"{i}{j - 1}";
            if (j - 1 >= 0 && !set.Contains(key))
            {
                set.Add(key);
                Search(board, r, c, i, j - 1, word, res, set, root);
                set.Remove(key);
            }
            key = $"{i}{j + 1}";
            if (j + 1 < c && !set.Contains(key))
            {
                set.Add(key);
                Search(board, r, c, i, j + 1, word, res, set, root);
                set.Remove(key);
            }
        }

        private bool ContainsWord(string word, TrieNode root)
        {
            var cur = root;
            foreach (var ch in word)
            {
                if (cur.arr[ch - 'a'] == null)
                    return false;
                else
                    cur = cur.arr[ch - 'a'];
            }

            if (cur.iseow)
                return true;
            return false;
        }

        private bool ContainsPrefix(string word, TrieNode root)
        {
            var cur = root;

            foreach (var ch in word)
            {
                if (cur.arr[ch - 'a'] == null)
                    return false;
                else
                    cur = cur.arr[ch - 'a'];
            }

            return true;
        }
    }
}
