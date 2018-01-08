using System;

namespace FactoryPattern.ExamplesForHumans.FactoryMethod
{
    public class CommunityExecutive : IInterviewer
    {
        public void AskQuestions()
        {
            Console.WriteLine("Asking about community building");
        }
    }
}
