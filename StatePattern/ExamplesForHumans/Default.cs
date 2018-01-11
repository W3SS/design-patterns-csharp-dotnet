using System;

namespace StatePattern.ExamplesForHumans
{
    public class Default : IWritingState
    {
        public void Write(string words)
        {
            Console.WriteLine(words);
        }
    }
}
