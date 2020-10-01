using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DemoConsole.BeingZero;
using DemoConsole.GFG;
using DemoConsole.Design;
using DemoConsole.Gs;
using DemoConsole.InterviewBits;
using DemoConsole.LeetCode;
using DemoConsole.LeetCode.maxxor;
using DemoConsole.LeetCode.PartitionLinkedList;
using DemoConsole.LeetCode.WordSearchII;
using DemoConsole.LeetCodelcs;
using PreOrderInOrder;
using DemoConsole.LeetCode.CarPolling;
namespace DemoConsole
{

    class Program
    {

        static void Main(string[] args)
        {

            //            ['o','a','a','n'],
            //['e','t','a','e'],
            //['i','h','k','r'],
            //['i','f','l','v']
            var chararr = new char[4][] {
                new char[4]{'o','a','a','n' },
                new char[4]{ 'e','t','a','e'},
                new char[4]{ 'i','h','k','r'},
                new char[4]{ 'i', 'f', 'l', 'v' }
            };

            #region 2-D Array Initialize
            //var arr = new int[4][] {
            //        new int[2] {  0 , 0 },
            //        new int[2] {  0 , 1},
            //        new int[2] {  1 , 2},
            //        new int[2] {  1 , 2},
            //        };
            #endregion

            #region Linked List Initialize
            var head1 = new ListNode(1);
            head1.next = new ListNode(2);
            head1.next.next = new ListNode(3);
            head1.next.next.next = new ListNode(4);
            head1.next.next.next.next = new ListNode(5);
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
            //[1,2,3,4,5], arr2 = [1,2,5,7,9], arr3 = [1,3,4,5,8]

            var stack = new Stack<int>();
            stack.Push(12);
            stack.Push(15);
            stack.Push(24);
            stack.Push(1);
            stack.Push(5);

            var obj = new SnowPack();
            
 
            var res = obj.Calculate(new int[] {1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1});
            
            Console.WriteLine(res);
        }

        public class Employee
        {
            public int age { get; set; }
            public string name { get; set; }

            public override bool Equals(object obj)
            {
                if (!(obj is Employee))
                    return false;

                if (((Employee)obj).name == this.name)
                {
                    return true;
                }
                return false;
            }

            public override int GetHashCode()
            {
                return this.name.GetHashCode();
            }

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




