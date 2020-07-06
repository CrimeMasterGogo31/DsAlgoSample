using System;
using System.Collections.Generic;
using System.Text;

namespace DemoConsole.BZ
{
    class BinaryCounting
    {
        void printBinaryCounting(int n)
        {
            if (n > 0)
            {
                Queue<string> q = new Queue<string>();
                q.Enqueue("1");
                Console.Write(0 + " ");
                n--;
                if (n > 0)
                {
                    while (n != 0)
                    {
                        var cur = q.Dequeue();
                        Console.Write(cur + " ");
                        n--;
                        q.Enqueue(cur + "0");
                        q.Enqueue(cur + "1");

                    }
                }
            }

        }
    }
}
