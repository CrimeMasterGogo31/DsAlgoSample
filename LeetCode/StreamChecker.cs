using System;
using System.Collections.Generic;
using System.Text;

namespace DemoConsole.LeetCode
{
    public class StreamChecker
    {
        HashSet<string> set = new HashSet<string>();
        List<char> list = new List<char>();
        TrieNode root = new TrieNode();
        public StreamChecker(string[] words)
        {
            foreach (var word in words)
            {
                var temp = root;
                var arr = word.ToCharArray();
                Array.Reverse(arr);
                var rev = new string(arr);
                foreach (var ch in rev)
                {
                    if (temp.arr[ch - 'a'] == null)
                        temp.arr[ch - 'a'] = new TrieNode();
                    temp = temp.arr[ch - 'a'];
                }
                temp.iseow = true;
            }
        }

        public bool Query(char letter)
        {

            list.Add(letter);
            int counter = 1;
            var temp = root;
            while (list.Count - counter >= 0)
            {

                if (temp.arr[list[list.Count - counter] - 'a'] == null)
                    return false;

                temp = temp.arr[list[list.Count - counter] - 'a'];

                if (temp.iseow)
                    return true;
                counter++;
            }
            return false;

        }
    }
    public class TrieNode
    {
        public TrieNode[] arr;
        public bool iseow;

        public TrieNode()
        {
            arr = new TrieNode[26];
        }
    }

}
