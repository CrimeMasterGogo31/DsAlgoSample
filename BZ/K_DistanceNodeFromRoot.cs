using System;
using System.Collections.Generic;
using System.Text;

namespace DemoConsole.BZ
{
    class K_DistanceNodeFromRoot
    {
        //public static void Main(string[] args)
        //{
        //    int t = Convert.ToInt32(Console.ReadLine().Trim());
        //    while (t-- != 0)
        //    {
        //        Console.ReadLine();
        //        int n = Convert.ToInt32(Console.ReadLine().Trim());
        //        var pre = Array.ConvertAll(Console.ReadLine().Trim().Split(' '),
        //                                   tmp => Convert.ToInt32(tmp));
        //        var ino = Array.ConvertAll(Console.ReadLine().Trim().Split(' '),
        //                                   tmp => Convert.ToInt32(tmp));
        //        var treeOps = new TreeOps();
        //        TreeOps.curInd = 0;
        //        var root = treeOps.Build(pre, ino, 0, n - 1);

        //        var queries = Array.ConvertAll(Console.ReadLine().Trim().Split(' '),
        //                                   tmp => Convert.ToInt32(tmp));
        //        foreach (var q in queries)
        //        {
        //            DistanceFromNode(root, q);
        //            Console.WriteLine();
        //        }
        //        Console.WriteLine();

        //    }
        //}


        private static void DistanceFromNode(bnode node, int dis)
        {
            if (node == null || dis < 0)
            {
                return;
            }

            if (dis == 0)
            {
                Console.Write(node.data+" ");
                return;
            }

            // Recur for left and right subtrees  
            DistanceFromNode(node.left, dis - 1);
            DistanceFromNode(node.right, dis - 1);

            //if (dis < 0)
            //{
            //    return;
            //}
            //if (dis == 0)
            //{
            //    if (node.left == null && node.right == null)
            //        Console.Write(node.data + " ");
            //    return;
            //}

            //if (node.left != null)
            //    DistanceFromNode(node.left, dis - 1);

            //if (node.right != null)
            //    DistanceFromNode(node.right, dis - 1);

            //return;
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
        public static int curInd = 0;
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

    }
}
