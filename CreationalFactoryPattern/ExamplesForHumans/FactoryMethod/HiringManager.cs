namespace FactoryPattern.ExamplesForHumans.FactoryMethod
{
    public abstract class HiringManager
    {
        // Factory method
        protected abstract IInterviewer MakeInterviewer();

        public void TakeInterview()
        {
            var interviewer = this.MakeInterviewer();

            interviewer.AskQuestions();
        }
    }
}
