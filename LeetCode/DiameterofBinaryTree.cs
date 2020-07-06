using System;
using System.Collections.Generic;
using System.Text;

namespace DemoConsole.LeetCode
{
    public class DiameterofBinaryTreeClass
    {
        public int DiameterOfBinaryTree(TreeNode root)
        {
            if (root == null)
                return 0;
            var left = Helper(root.left);
            var right = Helper(root.right);

            return left + right;
        }

        int Helper(TreeNode root)
        {
            if (root == null)
                return 0;

            var left = DiameterOfBinaryTree(root.left);
            var right = DiameterOfBinaryTree(root.right);
            return 1 + Math.Max(right, left);
        }
    }
}
