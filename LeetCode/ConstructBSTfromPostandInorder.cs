using System;
using System.Collections.Generic;
using System.Text;

namespace DemoConsole.LeetCode
{
    public class ConstructBSTfromPostandInorder
    {
        int cur;
        public TreeNode BuildTree(int[] inorder, int[] postorder)
        {
            cur = postorder.Length - 1;
            var root = Build(inorder, postorder, 0, inorder.Length);
            return root;
        }

        TreeNode Build(int[] ino, int[] post, int s, int e)
        {
            if (e < s)
                return null;
            var node = new TreeNode(post[cur--]);
            if (s == e)
                return node;
            var inorderroot = FindRootInInOrder(ino, s, e, node.val);
            node.right = Build(ino, post, inorderroot + 1, e);
            node.left = Build(ino, post, s, inorderroot - 1);

            return node;
        }

        int FindRootInInOrder(int[] inorder, int s, int e, int rootVal)
        {
            for (int i = s; i <= e; i++)
            {
                if (inorder[i] == rootVal)
                    return i;
            }
            return 0;
        }
    }
}
