using System;

namespace StatePattern.ExamplesForHumans
{
    class UpperCase : IWritingState
    {
        public void Write(string words)
        {
            Console.WriteLine(words.ToUpper());
        }
    }
}
