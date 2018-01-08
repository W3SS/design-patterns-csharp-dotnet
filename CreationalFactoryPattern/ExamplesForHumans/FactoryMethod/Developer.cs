using System;

namespace FactoryPattern.ExamplesForHumans.FactoryMethod
{
    class Developer : IInterviewer
    {
        public void AskQuestions()
        {
            Console.WriteLine("Asking about design patterns!");
        }
    }
}
