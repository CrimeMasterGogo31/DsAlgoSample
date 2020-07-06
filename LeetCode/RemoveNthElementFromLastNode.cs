using DemoConsole.LeetCode.PartitionLinkedList;
using System;
using System.Collections.Generic;
using System.Text;

namespace DemoConsole.LeetCode
{
    class RemoveNthElementFromLastNode
    {
        public ListNode RemoveNthFromEnd(ListNode head, int n)
        {
            ListNode f = head, s = head;
            ListNode d = new ListNode(0);
            d.next = head;
            int count = 0;
            int i = 0;
            while (head != null)
            {
                count++;
                head = head.next;
            }
            head = d;
            while (i < count - n)
            {
                head = head.next;
                i++;
            }
            if (head.next.next != null)
                head.next = head.next.next;
            else
                head.next = null;
            return d.next;

        }
    }
}
