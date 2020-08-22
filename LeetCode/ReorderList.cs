using DemoConsole.LeetCode.PartitionLinkedList;
using System;
using System.Collections.Generic;
using System.Text;

namespace DemoConsole.LeetCode
{
   public class ReorderListClass
    {
        public void ReorderList(ListNode head)
        {
            var middle = GetMiddleNode(head);
            var prev = middle;
            middle = middle.next;
            while (middle != null)
            {
                var temp = middle.next;
                middle.next = prev;
                prev = middle;
                middle = temp;
            }
            var last = prev;

            while (head.val != last.val)
            {
                var ht = head.next;
                head.next = last;
                head = ht;
                var lt = last.next;
                last.next = head;
                last = lt;
            }
        }

        ListNode GetMiddleNode(ListNode head)
        {
            var count = 0;
            var temp = head;
            while (temp != null)
            {
                temp = temp.next;
                count++;
            }

            temp = head;
            var mid = count / 2;
            while (--mid != 0)
            {
                temp = temp.next;
            }
            return temp;
        }
    }
    
}
