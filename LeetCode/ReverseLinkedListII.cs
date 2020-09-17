using DemoConsole.LeetCode.PartitionLinkedList;
using System;
using System.Collections.Generic;
using System.Text;

namespace DemoConsole.LeetCode
{
    public class ReverseLinkedListII
    {
        public ListNode ReverseBetween(ListNode head, int m, int n)
        {
            var cur = head;
            int count = 1;
            ListNode prev = null;
            while (count < m)
            {
                prev = cur;
                cur = cur.next;
                count++;
            }
            var start = cur;
            ListNode p = null;
            while (count <= n)
            {
                var t = cur.next;
                cur.next = p;
                p = cur;
                cur = t;
                count++;
            }
            if (m == 1)
            {
                head = p;
            }
            else
            {
                prev.next = p;

            }
            start.next = cur;
            return head;
        }
    }
}
