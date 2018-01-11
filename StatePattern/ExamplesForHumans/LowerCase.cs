using System;

namespace StatePattern.ExamplesForHumans
{
    public class LowerCase : IWritingState
    {
        public void Write(string words)
        {
            Console.WriteLine(words.ToLower());
        }
    }
}
