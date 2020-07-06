using System;
using System.Collections.Generic;
using System.Text;

namespace DemoConsole.BZ
{
    public class BST
    {
        public string value;
        public BST left;
        public BST right;
        public BST(string v)
        {
            value = v;
        }
    }
    public class BSTOperations
    {
        public void InsertInBST(BST root, string n)
        {
            //var node = new BST(n);
            

            if (root.value.CompareTo(n) <= 0)
                InsertInBST(root.left, n);
            else
                InsertInBST(root.right, n);
            //return root;
        }

    }
}
