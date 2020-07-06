using System;
using System.Collections.Generic;
using System.Text;

namespace DemoConsole.BZ
{
    using System;
    using System.Linq;
    using System.Collections.Generic;

    class BSTNode
    {
        public int data;
        public BSTNode left;
        public BSTNode right;
        public BSTNode(int d)
        {
            data = d;
            left = right = null;
        }
    }

    class BeingZero
    {
        public void PrintEachLevelOnNewLine(BSTNode root)
        {
            if (root == null)
                return;
            Queue<BSTNode> q = new Queue<BSTNode>();
            q.Enqueue(root);
            q.Enqueue(null);

            while (q.Count != 0)
            {
                var cur = q.Dequeue();

                if (cur == null)
                {
                    Console.WriteLine();
                    q.Dequeue();
                    if (q.Count != 0)
                        q.Enqueue(null);
                }
                else {
                    if (cur.left != null)
                    {
                        q.Enqueue(cur.left);
                    }
                    if (cur.right != null) {
                        q.Enqueue(cur.right);
                    }
                }
            }

        }
    }

}
