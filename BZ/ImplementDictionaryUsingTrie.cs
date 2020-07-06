using System;
using System.Collections.Generic;
using System.Text;

namespace DemoConsole.BZ
{
    class TNode
    {
        public const int ALPHABET_SIZE = 26;
        //public bool isEOW;
        public string value;
        public TNode[] next;

        public TNode()
        {
            next = new TNode[ALPHABET_SIZE];
        }
    }
    class TrieOps
    {
        public void GetValueForKey(TNode root, String word) //car
        {
            var temp = root;
            for (int i = 0; i < word.Length; i++)
            {
                int idx = word[i] - 'a';
                if (temp.next[idx] != null)
                {
                    temp = temp.next[idx];
                }
            }
            if (temp.value != null)
            {
                Console.Write(temp.value + " ");
            }
        }
        public void PutValueForKey(TNode root, String word, string value) //car
        {
            var temp = root;
            for (int i = 0; i < word.Length; i++)
            {
                int idx = word[i] - 'a';
                if (temp.next[idx] == null)
                {
                    temp.next[idx] = new TNode();
                }
                temp = temp.next[idx];

            }
            temp.value = value;
        }

        public bool CHECK(TNode root, string word)
        {
            var temp = root;
            for (int i = 0; i < word.Length; i++)
            {
                int idx = word[i] - 'a';
                if (temp.next[idx] == null)
                {
                    return false;
                }
                else
                {
                    temp = temp.next[idx];
                }
            }
            if (temp.value != null)
                return true;

            return false;
        }

        public bool IsPrefixExist(TNode root, string word)
        {
            var temp = root;
            for (int i = 0; i < word.Length; i++)
            {
                int idx = word[i] - 'a';
                if (temp.next[idx] == null)
                {
                    return false;
                }
                else
                {
                    temp = temp.next[idx];
                }
            }
            for (int i = 0; i < 26; i++)
            {
                if (temp.next[i] != null)
                    return true;
            }
            return false;
        }

        public void Remove(TNode root, string word)
        {
            var temp = root;
            for (int i = 0; i < word.Length; i++)
            {
                int idx = word[i] - 'a';
                if (temp.next[idx] == null)
                {
                    temp.next[idx] = new TNode();
                }
                temp = temp.next[idx];

            }
            temp.value = null;
        }

    }
    class ImplementDictionaryUsingTrie
    {
        //public static void Main(string[] args)
        //{
        //    TNode root = new TNode();
        //    TrieOps tops = new TrieOps();
        //    // BeingZeroTrie bzops = new BeingZeroTrie();
        //    String word;
        //    int t = Convert.ToInt32(Console.ReadLine());
        //    while (t-- != 0)
        //    {
        //        int n = Convert.ToInt32(Console.ReadLine());

        //        for (int i = 0; i < n; i++)
        //        {
        //            word = Console.ReadLine();
        //            var arr = word.Split(" ");
        //            var cond = arr[0].ToString().ToUpper();
        //            switch (cond)
        //            {
        //                case "PUT":
        //                    tops.PutValueForKey(root, arr[1], arr[2]);
        //                    break;
        //                case "GET":
        //                    tops.GetValueForKey(root, arr[1]);
        //                    break;
        //                case "ISPREFIX":
        //                    Console.Write(tops.IsPrefixExist(root, arr[1]).ToString().ToLower() + " ");
        //                    break;
        //                case "CHECK":
        //                    Console.Write(tops.CHECK(root, arr[1]).ToString().ToLower() + " ");
        //                    break;
        //                case "REMOVE":
        //                    tops.Remove(root, arr[1]);
        //                    break;

        //            }
        //        }
        //        // bzops.printWordsInTrie(root);
        //        Console.WriteLine();
        //    }
        //}
    }
}
