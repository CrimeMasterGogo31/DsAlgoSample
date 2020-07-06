using System;
using System.Collections.Generic;
using System.Text;

namespace DemoConsole.LeetCode
{
   class PathSumInTrer
    {
        public bool HasPathSum(TreeNode root, int sum)
        {
            if (root == null && sum == 0)
                return true;
            if (root.left == null && root.right == null && sum == 0)
                return true;
            bool left = false, right = false;
            if (root.left != null)
            {
                left = HasPathSum(root.left, sum - root.val);
            }

            if (left) return true;

            if (root.right != null)
            {
                right = HasPathSum(root.right, sum - root.val);
            }

            return left || right;

        }
    }
}
