using System;
using System.Collections.Generic;
using System.Text;

namespace DemoConsole.BZtst
{
    using System;
    using System.Linq;
    using System.Collections.Generic;

    class BeingZero
    {
        public void removeCycle(LLNode head)
        {
            if (head == null)
                return;
            var slow = head.next;
            if (head.next == null || head.next.next == null)
                return;
            var fast = head.next.next;
            if (head.next.next.data == head.data)
            {
                head.next.next = null;
            }
            if (head.next.data == head.data)
            {
                head.next = null;
                return;
            }
            while (fast != null && slow.data != fast.data)
            {
                slow = slow.next;
                if (fast.next == null)
                    return;
                fast = fast.next.next;
            }
            if (fast == null)
                return;

            var prev = slow;
            var temp = head;
            while (temp.data != slow.data)
            {
                prev = slow;
                slow = slow.next;
                temp = temp.next;
            }
            prev.next = null;

        }
    }


    class LLNode
    {
        public int data;
        public LLNode next;
        public LLNode(int d)
        {
            data = d;
            next = null;
        }
    }

    class LinkedListFunctions
    {
        public LinkedListFunctions()
        {
            last = null;
        }
        public void printList(LLNode head)
        {
            while (head != null)
            {
                Console.Write(head.data + " ");
                head = head.next;
            }
            Console.WriteLine();
        }
        LLNode last = null;
        public LLNode insertInEnd(LLNode head, int data)
        {
            LLNode t = new LLNode(data);
            if (last == null)
            {
                last = t;
                return t;
            }
            else
            {
                last.next = t;
                last = t;
            }
            return head;
        }
        public LLNode getLastNode(LLNode head)
        {
            return last;
        }
        public LLNode searchNode(LLNode head, int x)
        {
            if (head == null)
                return head;
            if (head.data == x)
                return head;
            return searchNode(head.next, x);
        }
        public LLNode insertInBeginning(LLNode head, int data)
        {
            LLNode t = new LLNode(data);
            t.next = head;
            return t;
        }
    }
    //class Test
    //{
    //    public static void Main(string[] args)
    //    {
    //        BeingZero bz = new BeingZero();
    //        int t = InputReader.ReadLineAsInt();
    //        while (t-- != 0)
    //        {
    //            LinkedListFunctions llf = new LinkedListFunctions();
    //            int[] numbers = InputReader.ReadSizeAndLineAsIntArray();
    //            LLNode head = null;
    //            for (int i = 0; i < numbers.Length; i++)
    //            {
    //                head = llf.insertInEnd(head, numbers[i]);
    //            }
    //            int[] cd = InputReader.ReadLineAsIntArray();
    //            if (cd[0] == 1)
    //            {
    //                LLNode cycleStart = llf.searchNode(head, cd[1]);
    //                llf.getLastNode(head).next = cycleStart;
    //            }
    //            bz.removeCycle(head);
    //            llf.printList(head);
    //        }
    //    }
    //}
    class InputReader
    {
        public static int ReadLineAsInt()
        {
            return Convert.ToInt32(Console.ReadLine().Trim());
        }

        public static int[] ReadLineAsIntArray()
        {
            return Array.ConvertAll(Console.ReadLine().Trim().Split(' '), wTemp => Convert.ToInt32(wTemp));
        }

        public static List<int> ReadLineAsIntList()
        {
            int[] a = ReadLineAsIntArray();
            return a.OfType<int>().ToList();
        }
        public static int[] ReadSizeAndLineAsIntArray()
        {
#pragma warning disable
            int n = ReadLineAsInt();
#pragma warning restore
            if (n == 0)
                return new int[0];
            return ReadLineAsIntArray();
        }
        public static List<int> ReadSizeAndLineAsIntList()
        {
#pragma warning disable
            int n = ReadLineAsInt();
#pragma warning restore
            if (n == 0)
                return null;
            return ReadLineAsIntList();
        }
    }
}
