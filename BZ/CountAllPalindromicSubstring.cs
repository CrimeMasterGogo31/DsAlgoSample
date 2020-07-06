using System;

class BeingZerore
{
    //public static void Main(string[] args)
    //{
    //    var t = Convert.ToInt32(Console.ReadLine().Trim());
    //    while (t-- != 0)
    //    {
    //        var s = Console.ReadLine().Trim();
    //        Console.WriteLine(LongestPalindromicSubStringLength(s));
    //    }
    //}
    public static int LongestPalindromicSubStringLength(string s)
    {
        int count = 0;
        bool[,] dp = new bool[s.Length, s.Length];

        for (int i = 0; i < s.Length; i++)
        {
            dp[i, i] = true;
        }

        for (int i = s.Length - 2; i >= 0; i--)
        {
            for (int j = i + 1; j < s.Length; j++)
            {
                if (s[i] == s[j])
                {
                    if (j - i == 1 || dp[i + 1, j - 1])
                    {
                        dp[i, j] = true;
                        count++;
                    }

                }
            }
        }
        //for (int i = 0; i < s.Length; i++)
        //{
        //    for (int j = 0; j < s.Length; j++)
        //    {
        //        Console.Write(dp[i, j] + " ");
        //    }
        //    Console.WriteLine();
        //}
        return count;
    }
}