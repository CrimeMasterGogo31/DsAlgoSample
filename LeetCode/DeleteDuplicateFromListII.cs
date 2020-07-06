using DemoConsole.LeetCode.PartitionLinkedList;
using System;
using System.Collections.Generic;
using System.Text;

namespace DemoConsole.LeetCode
{
    public class DeleteDuplicateFromListII
    {
        public ListNode DeleteDuplicates(ListNode head)
        {
            var dummy = new ListNode(0);

            var cur = dummy;
            while (head != null)
            {
                if (head.next != null && head.val == head.next.val)
                {
                    var dum = head;
                    while (head.next != null && head.val == head.next.val)
                    {
                        head = head.next;
                    }

                }
                else
                {
                    cur.next = head;
                    cur = cur.next;
                }
                head = head.next;
            }
            cur.next = null;
            return dummy.next;
        }
    }
}
