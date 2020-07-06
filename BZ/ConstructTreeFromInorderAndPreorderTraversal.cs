using DemoConsole.LeetCode;
using System;
using System.Collections.Generic;

namespace PreOrderInOrder
{
    public class SolutionInPre
    {
        static int cur = 0;
        public TreeNode BuildTree(int[] preorder, int[] inorder)
        {
            var root = MakeTree(preorder, inorder, 0, preorder.Length - 1);
            return root;
        }

        TreeNode MakeTree(int[] preorder, int[] inorder, int s, int e)
        {
            if (s > e)
                return null;
            var node = new TreeNode(preorder[cur++]);
            if (s == e)
                return node;
            var inorderroot = FindRootInInOrder(inorder,s,e, node.val);

            node.left = MakeTree(preorder, inorder, s, inorderroot - 1);

            node.right = MakeTree(preorder, inorder, inorderroot + 1, e);
            return node;
        }

        int FindRootInInOrder(int[] inorder,int s, int e, int rootVal)
        {
            for (int i = s; i <= e; i++)
            {
                if (inorder[i] == rootVal) 
                return i;
            }
            return 0;
        }
    }
    public class bnode
    {
        public int data = 0;
        public bnode left = null, right = null;
        public bnode(int d)
        {
            this.data = d;
        }
    }
    public class TreeOps
    {
        static int curInd = 0;
        public static List<int> path = new List<int>();
        public bnode Build(int[] pre, int[] ino, int s, int e)
        {
            if (s > e)
                return null;

            bnode node = new bnode(pre[curInd++]);
            if (s == e)
                return node;
            var inIndex = Search(ino, s, e, node.data);

            node.left = Build(pre, ino, s, inIndex - 1);
            node.right = Build(pre, ino, inIndex + 1, e);
            return node;
        }

        int Search(int[] ino, int s, int e, int data)
        {
            for (int i = s; i <= e; i++)
            {
                if (ino[i] == data)
                    return i;
            }
            return 0;
        }

        internal void PrintButtom(bnode node)
        {
            if (node.left == null && node.right == null)
            {
                path.Add(node.data);
                return;
            }

            if (node.left != null)
                PrintButtom(node.left);
            if (node.right != null)
                PrintButtom(node.right);
            return;
        }
    }

    class BeingZero12
    {
        //public static void Main(string[] args)
        //{
        //    int t = Convert.ToInt32(Console.ReadLine().Trim());
        //    while (t-- != 0)
        //    {
        //        int n = Convert.ToInt32(Console.ReadLine().Trim());
        //        var pre = Array.ConvertAll(Console.ReadLine().Trim().Split(' '),
        //                                   tmp => Convert.ToInt32(tmp));
        //        var ino = Array.ConvertAll(Console.ReadLine().Trim().Split(' '),
        //                                   tmp => Convert.ToInt32(tmp));
        //        var treeOps = new TreeOps();
        //        var root = treeOps.Build(pre, ino, 0, n - 1);
        //        TreeOps.path = new List<int>();
        //        treeOps.PrintButtom(root);
        //        foreach (var p in TreeOps.path) {
        //            Console.Write(p + " ");
        //        }
        //        Console.WriteLine();
        //    }
        //}
    }
}