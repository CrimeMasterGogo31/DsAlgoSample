using DemoConsole.LeetCode.PartitionLinkedList;
using System;
using System.Collections.Generic;
using System.Text;

namespace DemoConsole.LeetCode
{
    public class LinkedListAddition

    {

        public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
        {
            var templ1 = l1;
            ListNode revl1= new ListNode(0), revl2= new ListNode(0);
            ListNode prev = null;
            while (templ1 != null)
            {
                revl1 = templ1;
                var t = templ1.next;
                templ1.next = prev;
                prev = templ1;
                templ1 = t;
            }
            var templ2 = l2;
            prev = null;
            while (templ2 != null)
            {
                revl2 = templ2;
                var t = templ2.next;
                templ2.next = prev;
                prev = templ2;
                templ2 = t;
            }

            var dummy = new ListNode(0);
            ListNode res= new ListNode(0);
            dummy.next = res;
            var carry = 0;
            templ1 = revl1;
            templ2 = revl2;
            while (templ1 != null || templ2 != null)
            {
                var l1val = templ1 == null ? 0 : templ1.val;
                var l2val = templ2 == null ? 0 : templ2.val;
                var total = l1val + l2val + carry;

                res = new ListNode(total % 10);
                carry = total / 10;
                res = res.next;

                if (templ1 != null)
                    templ1 = templ1.next;
                if (templ2 != null)
                    templ2 = templ2.next;
            }

            var temp = dummy.next;
            prev = null;
            while (temp != null)
            {
                res = temp;
                var t = temp.next;
                temp.next = prev;
                prev = temp;
                temp = t;
            }

            return res;

        }
        //public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
        //{
        //    ListNode dummyHead = new ListNode(0);
        //    ListNode p = l1, q = l2, curr = dummyHead;
        //    int carry = 0;
        //    while (p != null || q != null)
        //    {
        //        int x = (p != null) ? p.val : 0;
        //        int y = (q != null) ? q.val : 0;
        //        int sum = carry + x + y;
        //        carry = sum / 10;
        //        curr.next = new ListNode(sum % 10);
        //        curr = curr.next;
        //        if (p != null) p = p.next;
        //        if (q != null) q = q.next;
        //    }
        //    if (carry > 0)
        //    {
        //        curr.next = new ListNode(carry);
        //    }
        //    return dummyHead.next;
        //}
        //public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
        //{
        //    var p = l1;
        //    var q = l2;
        //    ListNode r = null;
        //    ListNode ret = null;
        //    int c = 0;
        //    while (p != null && q != null)
        //    {
        //        var s = p.val + q.val + c;
        //        if (s > 9)
        //            c = 1;
        //        s = s % 10;
        //        if (r == null)
        //        {
        //            r = new ListNode(s);
        //            ret = r;
        //        }
        //        else
        //            r.next = new ListNode(s);

        //        p = p.next;
        //        q = q.next;
        //    }
        //    ListNode rem;
        //    if (p == null)
        //        rem = q;
        //    else
        //        rem = p;
        //    while (rem != null)
        //    {
        //        r.next = new ListNode(rem.val + c);
        //        rem = rem.next;
        //    }
        //    return ret;
        //}
        //public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
        //{
        //    var list1 = new List<int>();
        //    var list2 = new List<int>();
        //    while (l1 != null)
        //    {
        //        list1.Add(l1.val);
        //        l1 = l1.next;
        //    }
        //    while (l2 != null)
        //    {
        //        list2.Add(l2.val);
        //        l2 = l2.next;
        //    }
        //    var len1 = list1.Count - 1;
        //    var len2 = list2.Count - 1;
        //    var stk = new Stack<int>();
        //    int c = 0;
        //    while (len1 >= 0 && len2 >= 0)
        //    {
        //        var t = list1[len1--] + list2[len2--] + c;
        //        if (t > 9)
        //        {
        //            c = 1;
        //            t = t - 10;
        //        }
        //        else
        //            c = 0;
        //        stk.Push(t);
        //    }
        //    var remain = 0;
        //    var remainList = new List<int>();
        //    if (len1 >= 0)
        //    {
        //        remain = len1;
        //        remainList = list1;
        //    }
        //    else
        //    {
        //        remain = len2;
        //        remainList = list2;
        //    }
        //    while (remain >= 0)
        //    {
        //        stk.Push(remainList[remain--]+c);
        //    }
        //    var head = new ListNode(stk.Pop());
        //    head.next = create(stk);

        //    return head;
        //}

        static ListNode create(Stack<int> stk)
        {
            ListNode node;
            if (stk.Count > 0)
            {
                node = new ListNode(stk.Pop());
                node.next = create(stk);
            }
            else
                node = null;
            return node;
        }
    }
}
