﻿using System;
using System.Collections.Generic;
using DemoConsole.BeingZero;
using DemoConsole.BZ;
using DemoConsole.Design;
using DemoConsole.InterviewBits;
using DemoConsole.LeetCode;
using DemoConsole.LeetCode.PartitionLinkedList;
using PreOrderInOrder;

namespace DemoConsole
{

    class Program
    {

        static void Main(string[] args)
        {
            //0 0 1 0 0
            //0 0 0 0 0
            //0 0 0 1 0
            //1 1 0 1 1
            //0 0 0 0 0

            #region 2-D Array Initialize
            var arr = new int[4][] {
                    new int[2] {  0 , 0 },
                    new int[2] {  0 , 1},
                    new int[2] {  1 , 2},
                    new int[2] {  1 , 2},
                    };
            #endregion

            #region Linked List Initialize
            var head1 = new ListNode(1);
            head1.next = new ListNode(2);
            head1.next.next = new ListNode(3);
            head1.next.next.next = new ListNode(4);
            #endregion

            #region Tree Initialize
            var root = new TreeNode(1);
            root.left = new TreeNode(2);
            root.right = new TreeNode(3);
            root.left.left = new TreeNode(4);
            root.left.right = new TreeNode(5);
            #endregion

            var sc = new StreamChecker(new string[5] { "ab", "ba", "aaab", "abab", "baa" });
            var s1 = sc.Query('b');
            var s2 = sc.Query('a');
            var s3 = sc.Query('a');
            var s4 = sc.Query('a');
            var s5 = sc.Query('a');

            var BannedParagraphres = new BannedParagraph().MostCommonWord("a, b, a, b,b,b,c c", new string[1] { "b"});
        }

        public class compareClass : IComparer<char>
        {
            public int Compare(char x, char y)
            {
                return y - x; //descending order 
            }
        }
        public class compareIntClass : IComparer<int[]>
        {
            public int Compare(int[] x, int[] y)
            {
                if (x[1] == y[1]) //ascending order 
                    return y[0] - x[0];
                else
                    return y[1] - x[1];
            }
        }

        public int DaysBetweenDates(string date1, string date2)
        {
            var dateOne = DateTime.Parse(date1);
            var dateTwo = DateTime.Parse(date2);
            return Math.Abs((int)((dateTwo - dateOne).TotalDays));
        }
    }
}




