namespace StrategyPattern.ExamplesForHumans
{
    public class Sorter
    {
        protected ISortStrategy sorter;

        public Sorter(ISortStrategy sorter)
        {
            this.sorter = sorter;
        }

        public int[] Sort(int[] dataset)
        {
            return this.sorter.Sort(dataset);
        }
    }
}
