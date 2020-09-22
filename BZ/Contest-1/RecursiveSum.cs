using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace DemoConsole.BZ.Contest_1
{
    class RecursiveSum
    {
        static int superDigit(string n, int k)
        {
            if (n == "0")
                return 0;
            var sum = Calculate(n);
            sum *= k;

            while (sum.ToString().Length > 1)
            {
                sum = Calculate(sum.ToString());
            }
            return Convert.ToInt32(sum);
        }

        private static long Calculate(string num)
        {
            long sum = 0;
            for (int i = 0; i < num.Length; i++)
            {
                sum += (num[i]-'0');
            }
            return sum;
        }

        //static void Main(string[] args)
        //{
        //    //TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        //    string[] nk = Console.ReadLine().Split(' ');

        //    string n = nk[0];

        //    int k = Convert.ToInt32(nk[1]);

        //    int result = superDigit(n, k);

        //    // textWriter.WriteLine(result);

        //    //textWriter.Flush();
        //    //textWriter.Close();
        //}
    }
}
