using System;
using System.Collections.Generic;
using System.Text;

namespace DemoConsole.LeetCode
{
    public class VerticalOrderTraversal
    {
        Dictionary<int, int> dict = new Dictionary<int, int>();
        //public IList<IList<int>> VerticalTraversal(TreeNode root)
        //{
        //    var result = new List<IList<int>>();
        //    DFS(root, 0);
        //    var keyList = dict.Keys.;
        //    foreach (var key in keyList)
        //    {
        //        var list = new list<int>();
        //        foreach (var val in dict[key])
        //            list.Add(val);
        //        result.Add(list);
        //    }
        //    return result;
        //}

        //void DFS(TreeNode node, int ind)
        //{
        //    if (node == null)
        //        return;
        //    if (dict.ContainsKey(ind))
        //        dict[ind].Add(node.val);
        //    else
        //        dict.Add(ind, node.val);

        //    DFS(node.left, ind - 1);
        //    DFS(node.right, ind + 1);

        //}
    }
}
