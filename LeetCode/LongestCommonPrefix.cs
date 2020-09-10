using System;
using System.Collections.Generic;
using System.Text;

namespace DemoConsole.LeetCodelcs
{
    public class LongestCommonPrefixClass
    {
        public string LongestCommonPrefix(string[] strs)
        {
            var root = new TrieNode();

            var word = strs[0];
            var cur = root;
            foreach (var ch in word)
            {
                cur.next[ch - 'a'] = new TrieNode();
                cur.ind = ch - 'a';
                cur = cur.next[ch - 'a'];
            }
            cur.isEnd = true;

            foreach (var str in strs)
            {
                cur = root;
                for (int i = 0; i < str.Length; i++)
                {
                    var ch = str[i];
                    if (cur.next[ch - 'a'] == null)
                    {
                        break;
                    }
                    else
                    {
                        cur.ind = ch - 'a';
                        cur = cur.next[ch - 'a'];
                    }
                }
                cur.isEnd = true;
            }

            var res = "";
            while (!root.isEnd)
            {
                res += Convert.ToChar('a' + root.ind).ToString();
                root = root.next[root.ind];
            }
            return res;
        }


    }

    class TrieNode
    {
        public bool isEnd;
        public TrieNode[] next;
        public int ind;

        public TrieNode()
        {
            next = new TrieNode[26];
        }
    }
}
