using System;
using System.Collections.Generic;
using System.Text;

namespace DemoConsole.BZ
{
    class ReverseLL {
        //public static void Main()
        //{
        //    var head = new ReverseLinkedListNodeWise().ConstructLL(new int[6] { 1, 2, 3, 4, 5, 6 });
        //    var rev_head = new ReverseLinkedListNodeWise().reverseK(head, 3);
        //}
    }
    public class LLNode
    {
        public int data;
        public LLNode next;
        public LLNode(int d)
        {
            data = d;
            next = null;
        }
    }

    class ReverseLinkedListNodeWise
    {
        public LLNode ConstructLL(int[] items)
        {
            LLNode head = null;
            LLNode tail = null;
            foreach (int item in items)
            {
                if (head == null)
                {
                    head = new LLNode(item);
                    tail = head;
                    continue;
                }
                tail.next = new LLNode(item);
                tail = tail.next;
            }

            return head;
        }

        public LLNode reverseK(LLNode head, int k)
        {
           
            LLNode next = null;
            LLNode prev = null;
            LLNode curr = head;
            int i = 0;

            while (curr != null && i++ < k)
            {
                next = curr.next;
                curr.next = prev;
                prev = curr;
                curr = next;
            }

            if (next != null)
            {
                head.next = reverseK(curr, k);
            }

            return prev;
        }
    }
}
