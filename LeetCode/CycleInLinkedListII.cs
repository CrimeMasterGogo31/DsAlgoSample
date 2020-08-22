using DemoConsole.LeetCode.PartitionLinkedList;
using System;
using System.Collections.Generic;
using System.Text;

namespace DemoConsole.LeetCode
{
    public class CycleInLinkedListII
    {
        public ListNode DetectCycle(ListNode head)
        {
            if (head == null)
                return null;

            var slow = head.next;
            var fast = head.next.next;

            while (slow != null && fast != null)
            {
                if (slow.val == fast.val)
                    break;

                slow = slow.next;
                fast = fast.next.next;

            }

            while (slow != head)
            {
                slow = slow.next;
                head = head.next;
            }
            return head;
        }
    }
}
