using System;
using System.Collections.Generic;
using System.Text;

namespace DemoConsole.LeetCode
{
    public class TreeNode
    {
        public int val;
        public TreeNode left;
        public TreeNode right;
        public TreeNode(int x) { val = x; }
    }
    class MaxPathSumInBinaryTree
    {
        public class MaxPathSumInBinary
        {
            static int max;
            public int MaxPathSum(TreeNode root)
            {
                max = int.MinValue;
                MaxPathSumHelper(root);
                return max;
            }
            public int MaxPathSumHelper(TreeNode root)
            {
                if (root == null)
                    return 0;
                var l = Math.Max(MaxPathSumHelper(root.left), 0);
                var r = Math.Max(MaxPathSumHelper(root.right), 0);
                var s = l + r + root.val;

                max = Math.Max(max, s);

                return root.val + Math.Max(l, r);
            }
        }
    }
}
