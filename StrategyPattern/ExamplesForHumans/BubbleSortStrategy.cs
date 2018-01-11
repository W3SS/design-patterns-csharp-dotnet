using System;

namespace StrategyPattern.ExamplesForHumans
{
    public class BubbleSortStrategy : ISortStrategy
    {
        public int[] Sort(int[] dataset)
        {
            Console.WriteLine("Sorting using bubble sort");

            // Do sorting

            return dataset;
        }
    }
}
