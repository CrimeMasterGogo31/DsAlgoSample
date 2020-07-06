using System;
using System.Collections.Generic;
using System.Text;

namespace DemoConsole.LeetCode
{
    public class ConstructBinartSearchTreeFromPreOrder
    {
        int cur;
        public TreeNode BstFromPreorder(int[] pre)
        {
            var ino = new int[pre.Length];
            for (int i = 0; i < pre.Length; i++)
                ino[i] = pre[i];
            Array.Sort(ino);
            cur = 0;
            return build(pre, ino, 0, ino.Length - 1);
        }

        TreeNode build(int[] pre, int[] ino, int s, int e)
        {
            if (s > e)
                return null;
            var node = new TreeNode(pre[cur++]);
            if (s == e)
                return node;

            var inoInd = FindIndex(ino, node.val, s, e);

            node.left = build(pre, ino, s, inoInd - 1);
            node.right = build(pre, ino, inoInd + 1, e);
            return node;
        }

        int FindIndex(int[] ino, int val, int s, int e)
        {

            for (int i = s; i <= e; i++)
            {
                if (ino[i] == val)
                    return i;
            }
            return 0;
        }
    }
}
