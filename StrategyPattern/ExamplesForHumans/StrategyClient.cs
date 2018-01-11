using System;

namespace StrategyPattern.ExamplesForHumans
{
    public class StrategyClient
    {
        public static void Demo()
        {
            var dataset = new int[] { 1, 5, 4, 3, 2, 8 };

            var sorter = new Sorter(new BubbleSortStrategy());
            sorter.Sort(dataset); // Output : Sorting using bubble sort

            var sorter2 = new Sorter(new QuickSortStrategy());
            sorter2.Sort(dataset); // Output : Sorting using quick sort

            Console.ReadLine();
        }
    }
}
