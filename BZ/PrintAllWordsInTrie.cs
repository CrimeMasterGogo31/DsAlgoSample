using System;
using System.Collections.Generic;
using System.Text;

//namespace DemoConsole.BZ
//{
//    using System;
//    using System.Text;
//    using System.Collections.Generic;

//    class TNode
//    {
//        public const int ALPHABET_SIZE = 26;
//        public bool isEOW;
//        public TNode[] next;

//        public TNode()
//        {
//            next = new TNode[ALPHABET_SIZE];
//        }
//    }

//    class BeingZeroTrie
//    {

//        List<char> list = new List<char>();
//        public void printWordsInTrie(TNode root)
//        {

//            if (root.isEOW)
//            {
//                foreach (var c in list)
//                {
//                    Console.Write(c);
//                }
//                Console.Write(" ");
//            }
//            for (int i = 0; i < 26; i++)
//            {
//                if (root.next[i] != null)
//                {
//                    list.Add((char)(i + 'a'));
//                    printWordsInTrie(root.next[i]);
//                    list.RemoveAt(list.Count - 1);
//                }
//            }

//        }

//    }

//    class TrieOps
//    {

//        public void insertWordInTrie(TNode root, String word)
//        {
//            TNode temp = root;
//            for (int i = 0; i < word.Length; i++)
//            {
//                int idx = word[i] - 'a';
//                if (temp.next[idx] == null)
//                {
//                    temp.next[idx] = new TNode();
//                }
//                temp = temp.next[idx];
//            }
//            temp.isEOW = true;
//        }
//    }

//    public class Test
//    {
//        //public static void Main(string[] args)
//        //{
//        //    TNode root = new TNode();
//        //    TrieOps tops = new TrieOps();
//        //    BeingZeroTrie bzops = new BeingZeroTrie();
//        //    String word;
//        //    int t = Convert.ToInt32(Console.ReadLine());
//        //    while (t-- != 0)
//        //    {
//        //        int n = Convert.ToInt32(Console.ReadLine());
//        //        if (n > 0)
//        //        {
//        //            for (int i = 0; i < n; i++)
//        //            {
//        //                word = Console.ReadLine();
//        //                tops.insertWordInTrie(root, word);
//        //            }
//        //        }
//        //        bzops.printWordsInTrie(root);
//        //        Console.WriteLine();
//        //    }
//        //}
//    }
//}
