using System;
using System.Collections.Generic;
using System.Text;

namespace DemoConsole.LeetCode
{
    public class StockSpanner
    {
        List<int> prices;
        List<int> spans;
        int total;
        public StockSpanner()
        {
            prices = new List<int>();
            spans = new List<int>();
        }

        public int next(int price)
        {
            if (total == 0)
            {
                prices.Add(price);
                spans.Add(1);
                total++;
            }
            else
            {
                var prevPrice = prices[total - 1];
                int prevInd = total - 1;
                int span = 1;

                while (prevPrice <= price)
                {
                    var temp = spans[prevInd];
                    span += spans[prevInd];
                    if (prevInd == 0 || prevInd - temp<0)
                        break;
                    prevPrice = prices[prevInd - temp];
                    prevInd -= temp;
                }
                prices.Add(price);
                spans.Add(span);
                total++;
            }
            return spans[total - 1];

        }
    }
}
