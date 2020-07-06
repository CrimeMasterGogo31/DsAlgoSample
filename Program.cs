using System;
using System.Collections.Generic;
using DemoConsole.Design;
using DemoConsole.InterviewBits;
using DemoConsole.LeetCode;
using DemoConsole.LeetCode.PartitionLinkedList;
using PreOrderInOrder;

namespace DemoConsole
{


    class Program
    {
        static void PrintTriangle(int n)
        {
            char[,] arr = new char[n, n];

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < i + 1; j++)
                {
                    arr[i, n - j - 1] = '*';
                }

            }
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(arr[i, j]);
                }
                Console.WriteLine();
            }
        }
        private static int Reverse(int n)
        {
            int temp = 0;
            while (n > 0)
            {
                temp = (temp * 10) + n % 10;
                n /= 10;
            }
            return temp;
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




        public static int NumSteps(string str)
        {
            var s = str.ToCharArray();
            int count = 0;
            int i = str.Length - 1;
            while (i >= 0)
            {
                if (s[i] == '0')
                {
                    count++;
                    i--;
                    continue;
                }
                if (s[i] == '1')
                {
                    s[i] = '0';
                    count++;
                }

            }
            return count;
        }



        static int MakeOne(long val, int count)
        {
            if (val == 1)
                return count;
            if (val % 2 == 0)
                return MakeOne(val / 2, count + 1);
            else
                return MakeOne(val + 1, count + 1);
        }



        static void Main(string[] args)
        {
            var recon = new ReconstructQueueClass().ReconstructQueue(new int[6][] { new int[2] { 7, 0 },
            new int[2] { 4, 4 },
            new int[2] { 7, 1 },new int[2] {5, 0 },new int[2] {6, 1 },new int[2] {5, 2} });

            var CanFinishCourse = new SortestPointFromOrigin().KClosest(new int[2][] { new int[2] { -2, 2 }, new int[2] { 1, 3 } }, 1);
            var dd = new FrequecySort().FrequencySort("tree");

            //78],[30],[40],[50],[60],[80],[90
            var S = new StockSpanner();
            S.next(78);
            S.next(30);
            S.next(40);
            S.next(50);
            S.next(60);
            S.next(80);
            S.next(90);
            var AnagramInString = new AnagramInString().FindAnagrams("cbaebabacd", "abc");
            var RemoveKDigitClass = new RemoveKDigitClass().RemoveKdigits("10200", 1);

            var FractionToDecimalClass = new FractionToDecimalClass().FractionToDecimal(5, 8);
            //[0,1,1],[1,1,2],[1,0,1]]
            var tic = new Design.TicTacToe(2);
            var r1 = tic.Move(0, 1, 1);
            var r2 = tic.Move(1, 1, 2);
            var r3 = tic.Move(1, 0, 1);
            var FloodFillc = new FloodFillc().FloodFill(new int[2][] { new int[3] { 0, 0, 0 }, new int[3] { 0, 0, 0 } }, 0, 0, 2);

            var ss = new ConstructBSTfromPostandInorder().BuildTree(new int[5] { 9, 3, 15, 20, 7 }, new int[5] { 9, 15, 7, 20, 3 });
            //var ss = new ParenthesisMatching().CheckValidString("((**");
            var arr = new int[6] { 5, 7, 7, 8, 8, 10 };
            Console.WriteLine(arr);
            var sl = new LastStoneWeightClass().LastStoneWeight(new int[5] { 4, 3, 4, 3, 2 });
            //"1432219", k = 3
            var cx = new RemoveKintergerFromString().RemoveKdigits("1432219", 3);
            var binary = new BinarySearchRange().SearchRange(new int[6] { 5, 7, 7, 8, 8, 10 }, 8);

            //            var BackspaceCompare = new BackSpaceStringCompare().BackspaceCompare("y#fo##f",

            var head1 = new ListNode(7);
            head1.next = new ListNode(2);
            head1.next.next = new ListNode(4);
            head1.next.next.next = new ListNode(3);
            head1.next.next.next.next = null;

            var head2 = new ListNode(5);
            head2.next = new ListNode(6);
            head2.next.next = new ListNode(4);
            head2.next.next.next = null;
            var LinkedListAddition = new LinkedListAddition().AddTwoNumbers(head1, head2);


            var SearchIn2DMatrix = new SearchIn2DMatrix().SearchMatrix(new int[3][] {
                                                                                     new int[4] { 1,3,5,7 },
                                                                                     new int[4] { 10, 11, 16, 20 },
                                                                                     new int[4] { 23, 30, 34, 50 }
                                                                                    }, 11);
            var PartitionLabels = new StringPartition().PartitionLabels("aabaccd");//(2,7,10);
            var aa = NumSteps("1101");
            new SortColorClass().SortColors(new int[3] { 0, 2, 1 });
            var GroupAnagramscls = new GroupAnagramscls().GroupAnagrams(new string[6] { "eat", "tea", "tan", "ate", "nat", "bat" });

            var root = new TreeNode(1);
            root.left = new TreeNode(2);
            root.right = new TreeNode(3);
            root.left.left = new TreeNode(4);
            root.left.right = new TreeNode(5);
            var o = new DiameterofBinaryTreeClass().DiameterOfBinaryTree(root);


            var SkyLinec = new SkyLine().GetSkyline(new int[5][] { new int[3] { 2 ,9, 10 },
            new int[3] { 3, 7 ,15 },
            new int[3] { 5, 12, 12 },
            new int[3] { 15, 20 ,10 },
            new int[3] { 19 ,24 ,8 },});
            //[2 9 10], [3 7 15], [5 12 12], [15 20 10], [19 24 8] 


            //var GroupOddEvenLinkedList = new GroupOddEvenLinkedList().OddEvenList(head);

            //cache.put(1, 1);
            //cache.put(2, 2);
            //var v1 = cache.get(1);       // returns 1
            //cache.put(3, 3);    // evicts key 2
            //var v2 = cache.get(2);       // returns -1 (not found)
            //cache.put(4, 4);    // evicts key 1
            //var v3 = cache.get(1);       // returns -1 (not found)
            //var v4 = cache.get(3);       // returns 3
            //var v5 = cache.get(4);

            new MergeTwoSortedArray().Merge(new int[6] { 1, 2, 3, 0, 0, 0 }, 3, new int[3] { 2, 5, 6 }, 3);

            //var NQueen = new NQueen().SolveNQueens(4);
            //var Primec = new Primec().SumFourDivisors(new int[3] { 21, 4, 7 });
            //var PathInGrid = new PathInGrid().HasValidPath(new int[2][] { new int[3] { 2, 4, 3 }, new int[3] { 6, 5, 2 } });
            //[[2,4,3],[6,5,2]]
            //var candy = new CandyClass().Candy(new int[5] { 1, 3, 4, 5, 2 });

            //var NextClosetTime = new NextClosetTime().NextClosestTime("00:00");
            //var FindMissingRanges = new MissingRange().FindMissingRanges(new int[5] { 0, 1, 3, 50, 75 }, 4,49);

            var sss = new LongestSubstringWithAtmost2DistinctCharacters().LengthOfLongestSubstringTwoDistinct("ccacabbb");
            //var wc = new WordSearchII().FindWords(
            //    new char[1][] { new char[2] { 'a', 'a' } },
            //    new string[1] { "aaa" });
            //var ll = new LuckyNumber().LuckyNumbers(new int[][]{
            //    new int[] {3,7,8 }, new int[] {9,11,13},
            //    new int[] { 15,16,17 }});
            //[[3,7,8],[9,11,13],[15,16,17]]
            // var arr = Array.ConvertAll(Console.ReadLine().Trim().Split(' '),
            //     tmp => Convert.ToInt32(tmp));
            //var temp = Convert.ToDouble(Console.ReadLine().Trim());
            // var resss = new BulbSwitch().NumTimesAllBlue(new int[6] { 1, 2, 3, 4, 5, 6 });

            var res = new ListNode(1);
            res.next = new ListNode(2);
            res.next.next = new ListNode(2);

            var DeleteDuplicateFromListIIres = new DeleteDuplicateFromListII().DeleteDuplicates(res);
            //var minw = new MinWindowSubstring().MinWindow("ADOBECODEBANC","ABC");

            //var res1 = new MinMeetingRoomsClass().MinMeetingRooms(
            //    new int[][] { new int[] { 1, 8 }, new int[] { 6, 20 }
            //    , new int[] { 9, 16 }
            //    , new int[] { 13, 17 }
            //    });
            //[[1,8],[6,20],[9,16],[13,17]]
            // var res = new LongestSubstringNonRepeatedChar().LengthOfLongestSubstring("pwwkew");
            //var s = ClosestDivisors(8);
            //[1,0,1,4,1,4,1,2,3]

            //var res = new FruitIntoBasket().TotalFruit(new int[] { 1, 0, 1, 4, 1, 4, 1, 2, 3 });


            //var resss = new SolutionK().MinSetSize(new int[] { 9, 77, 63, 22, 92, 9, 14, 54, 8, 38, 18, 19, 38, 68, 58, 19 });
            //var rr = new LicenceKeyFormatting().LicenseKeyFormatting("5F3Z-2e-9-w", 4);

            //new Solution173().FindTheCity(5, new int[][]{
            //    new int[] {1,5 }, new int[] { 1,5},
            //    new int[] { 1,5 }, new int[] { 2,3}, new int[] { 2,3 }  }, 2);
            ////[[1,5],[1,5],[1,5],[2,3],[2,3]]
            ////2

            //var inp = new int[][] { new int[]{ 1, 4, 1, 40, 10 }, new int[] { 2, 8, 0, 50, 5 },
            //    new int[] { 3, 8, 1, 30, 4 }, new int[] { 4, 10, 0, 10, 3 }, new int[]{ 5, 1, 1, 15, 1 } };
            //var ans = new SolutionLeetCode173().FilterRestaurants(inp, 1, 50, 10);

            //new LongestCommonSubStringLength().lcSubstringLen("grapple", "zpplaa");
            //int x = 9643;
            //int y = Reverse(x);


        }

        private static int LongestCommonSubstring(string a, string b, int alen, int blen, int count)
        {
            if (alen == 0 || blen == 0)
                return 0;

            if (a[alen - 1] == b[blen - 1])
            {
                count = LongestCommonSubstring(a, b, alen - 1, blen - 1, count + 1);
            }

            count = Math.Max(
                            count,
                            Math.Max(
                                LongestCommonSubstring(a, b, alen - 1, blen, 0),
                                LongestCommonSubstring(a, b, alen, blen - 1, 0)));
            return count;
        }

    }
}

