using System;
using System.Collections.Generic;
using System.Text;

namespace DemoConsole.LeetCode
{
    public class Node
    {
        public int val;
        public Node next;
        public Node random;

        public Node(int _val)
        {
            val = _val;
            next = null;
            random = null;
        }
    }
    //public class CopyLinkedListWithRandomPointer
    //public Node CopyRandomList(Node head)
    //{
    //    if (head == null)
    //        return null;
    //    var copy = new Node(0);
    //    var temp = head;
    //    while (head != null)
    //    {
    //        var newNode = new Node(head.val);
    //        var t = head.next;
    //        head.next = newNode;
    //        newNode.next = t;
    //        head = t;

    //    }
    //    head = temp;

    //    while (head != null)
    //    {
    //        head.next.random = head.random?.next;
    //        head = head.next.next;
    //    }
    //    head = temp;
    //    copy.next = head.next;

    //    while (head.next != null)
    //    {
    //        var te = head.next;
    //        head.next = head.next.next;
    //        head = te;
    //    }
    //    return copy.next;
    //}
}
