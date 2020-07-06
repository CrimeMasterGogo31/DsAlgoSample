using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DemoConsole.LeetCode
{

    public class MaximumNumberOfEventThatCanBeAttended
    {
        public int MaxEvents(int[][] events)
        {
            if (events == null || events.Length == 0)
                return 0;
            var sortedEvents = events.OrderBy(x => x[1]).ThenBy(x=>x[0]).ToList();

            var hash = new HashSet<int>();

            foreach (var e in sortedEvents)
            {
                if (hash.Contains(e[0]))
                {
                    var t = e[0] + 1;
                    while (t <= e[1])
                    {
                        if (!hash.Contains(t))
                        {
                            hash.Add(t);
                            continue;
                        }
                        t++;
                    }
                }
                else
                {
                    hash.Add(e[0]);
                }

            }

            return hash.Count;
        }


    }

}
