using System;
using System.Collections.Generic;
using System.Text;

namespace DemoConsole.LeetCode.PartitionLinkedList
{
    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int x) { val = x; }
    }

    public class PartitionLinkedList
    {
        public ListNode Partition(ListNode temp, int x)
        {
            ListNode prev = null;
            ListNode greater = null;
            ListNode head = null;
            ListNode returnValue = null;
            while (temp != null)
            {
                if (temp.val >= x)
                {
                    if (greater == null)
                    {
                        greater = new ListNode(temp.val);
                        head = greater;
                    }
                    else
                    {
                        greater.next = new ListNode(temp.val);
                        greater = greater.next;
                    }
                }
                else
                {
                    if (prev == null)
                    {
                        prev = new ListNode(temp.val);
                        returnValue = prev;
                    }
                    else
                    {
                        prev.next = new ListNode(temp.val);
                        prev = prev.next;
                    }

                    //if (temp.next != null)
                    //{
                    //    temp.val = temp.next.val;
                    //    temp.next = temp.next.next;
                    //}
                    //else
                    //{
                    //    temp = null;
                    //}

                }
                temp = temp.next;
            }
            prev.next = head;
            return returnValue;
        }
    }
}