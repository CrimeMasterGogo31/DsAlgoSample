using System;
using System.Collections.Generic;
using System.Text;

namespace DemoConsole.LeetCode
{
    public class LN
    {
        public int val;
        public LN next;
        public LN prev;
        public LN(int v)
        {
            val = v;
        }
    }


    public class LRUCache
    {
        LN front;
        LN back;
        int limit;
        Dictionary<int, int> dict;
        public LRUCache(int capacity)
        {
            front = new LN(-1);
            back = new LN(-1);
            front.prev = back;
            back.next = front;
            limit = capacity;
            dict = new Dictionary<int, int>();
        }

        public int get(int key)
        {
            if (dict.ContainsKey(key))
            {
                MoveNodeTOFront(key);
                return dict[key];
            }
            else
                return -1;
        }

        public void put(int key, int value)
        {
            var cur = new LN(key);
            if ((!dict.ContainsKey(key) && dict.Count < limit))
            {
                InsetAtFront(cur);
            }
            else if (!dict.ContainsKey(key) && dict.Count >= limit)
            {
                var v = back.next.val;
                dict.Remove(v);
                back.next = back.next.next;
                back.next.prev = back;
                InsetAtFront(cur);

            }

            else if (dict.ContainsKey(key))
            {
                MoveNodeTOFront(key);
                dict[key] = value;
                return;
            }
            if (dict.ContainsKey(key))
                dict[key] = value;
            else
                dict.Add(key, value);
        }

        private void InsetAtFront(LN cur)
        {
            if (front.prev.val == -1)
            {
                cur.prev = front.prev;
                cur.next = front;
                back.next = cur;
                front.prev = cur;
            }
            else
            {
                front.prev.next = cur;
                cur.prev = front.prev;
                cur.next = front;
                front.prev = cur;
            }
        }

        private void MoveNodeTOFront(int key)
        {
            var cur = back.next;

            while (cur.val != key)
            {
                cur = cur.next;
            }

            if (cur.next.val != -1)
            {
                cur.prev.next = cur.next;
                cur.next.prev = cur.prev;

                var t = front.prev;
                t.next = cur;
                cur.prev = t;
                cur.next = front;
                front.prev = cur;
            }

        }
    }

    /**
     * Your LRUCache object will be instantiated and called as such:
     * LRUCache obj = new LRUCache(capacity);
     * int param_1 = obj.Get(key);
     * obj.Put(key,value);
     */
}
