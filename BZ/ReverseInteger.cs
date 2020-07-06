using System;
using System.Linq;
class BeingZero
{
    public int getReverseN(int N)
    {
        int temp = 0;
        while (N != 0)
        {
            temp = temp * 10;
            temp = temp + N % 10;
            N = N / 10;
        }
        return temp;
    }
}

class Test
{
    //public static void Main(string[] args)
    //{
    //    BeingZero bz = new BeingZero();
    //    String line = "";
    //    while ((line = Console.ReadLine()) != null)
    //    {
    //        int n = Convert.ToInt32(line.Trim());
    //        Console.WriteLine(bz.getReverseN(n));
    //    }
    //}
}