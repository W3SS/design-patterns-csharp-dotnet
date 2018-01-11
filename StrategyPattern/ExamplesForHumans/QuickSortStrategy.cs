using System;

namespace StrategyPattern.ExamplesForHumans
{
    public class QuickSortStrategy : ISortStrategy
    {
        public int[] Sort(int[] dataset)
        {
            Console.WriteLine("Sorting using quick sort");

            // Do sorting

            return dataset;
        }
    }
}
