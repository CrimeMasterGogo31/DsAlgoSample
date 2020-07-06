using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;

namespace DemoConsole
{
    class ChunkPrintin1Minute
    {
        public void SendInChunk()
        {
            List<int> list = new List<int>();
            for (int i = 1; i <= 100; i++)
            {
                list.Add(i);
            }

            var timer = Stopwatch.StartNew();
            //var chunkList = list.ChunkBy(25);
            Action<object> callBackResult = r =>
            {
                Console.Write(r.ToString());
            };
            //var timerCallBack = new TimerCallback(PrintNumbers);

            //var state = new TimerExampleState();
            //var timer = new Timer(timerCallBack, state, 10000, 10000);

        }

        private void PrintNumbers(IList<int> chunk)
        {
            //foreach (var i in chunk)
            //{
            //    Console.WriteLine(i);
            //}
        }

        class TimerExampleState
        {
            public int counter = 0;
            public Timer tmr;
        }


    }

    public static class ListExtensions
    {
        public static IEnumerable<IEnumerable<T>> ChunkBy<T>(this IList<T> source, int chunkSize)
        {
            return source
                .Select((x, i) => new { Index = i, Value = x })
                .GroupBy(x => x.Index / chunkSize)
                .Select(x => x.Select(v => v.Value));
        }
    }
}
