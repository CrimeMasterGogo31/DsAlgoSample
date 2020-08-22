using System.Collections.Generic;
namespace DemoConsole.LeetCode.LevelOrder
{
    public class TreeNode
    {
        public int val;
        public TreeNode left;
        public TreeNode right;
        public TreeNode(int value)
        {
            val = value;
        }
    }

    public class LevelOrderTraversal
    {
        public IList<IList<int>> LevelOrder(TreeNode root)
        {

            var result = new List<IList<int>>();
            var queue = new Queue<TreeNode>();

            var level = new List<int>();
            if (root == null)
            {
                return result;
            }
            queue.Enqueue(root);
            queue.Enqueue(null);
            while (queue.Count > 0)
            {
                var cur = queue.Dequeue();
                if (cur == null)
                {
                    if (level.Count > 0)
                        result.Add(level);

                    level = new List<int>();
                    if (queue.Count > 0)
                        queue.Enqueue(null);
                }
                else
                {
                    level.Add(cur.val);
                    if (cur.left != null)
                        queue.Enqueue(cur.left);
                    if (cur.right != null)
                        queue.Enqueue(cur.right);

                }
            }
            return result;
        }

    }
}