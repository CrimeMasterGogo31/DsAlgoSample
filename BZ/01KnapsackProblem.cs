using System;
using System.Collections.Generic;
using System.Text;

namespace DemoConsole.BZ
{
    class _01KnapsackProblem
    {
        public class Item
        {
            public int weight;
            public int value;

            public Item(int weight, int value)
            {
                this.weight = weight;
                this.value = value;
            }
        }

        public int maxValue(Item[] items, int capacity)
        {
            return maxValueCalculate(items, items.Length, capacity, 0);
        }

        private int maxValueCalculate(Item[] items, int n, int c, int sum)
        {
            if (n <= 0)
            {
                return 0;
            }
            if (c == 0)
            {
                return sum;
            }
            if (c < 0)
            {

                return 0;
            }
            return Math.Max(maxValueCalculate(items, n - 1, c - items[n - 1].value, sum + items[n - 1].value),
                    maxValueCalculate(items, n - 1, c, sum));
        }
    }
}
