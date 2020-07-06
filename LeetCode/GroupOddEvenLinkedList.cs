using DemoConsole.LeetCode.PartitionLinkedList;
using System;
using System.Collections.Generic;
using System.Text;

namespace DemoConsole.LeetCode
{
    public class GroupOddEvenLinkedList
    {
        public ListNode OddEvenList(ListNode head)
        {

            if (head == null)
                return null;
            if (head.next == null)
                return head;
            ListNode odd = head;
            ListNode even = head.next;
            ListNode dummy = new ListNode(0);
            dummy.next = odd;

            var temp = even;
           

            while (odd != null && even != null)
            {
                if (even.next == null)
                {
                    odd.next = temp;
                    break;
                }
                odd.next = even.next;
                odd = odd.next;

                if (odd.next == null)
                {
                    even.next = null;
                    odd.next = temp;
                    break;
                }
                even.next = odd.next;
                even = even.next;
            }
            return dummy.next;

        }
    }
}
