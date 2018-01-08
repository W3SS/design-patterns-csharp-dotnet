namespace FactoryPattern.ExamplesForHumans.FactoryMethod
{
    public abstract class HiringManager
    {
        // Factory method
        protected abstract IInterviewer makeInterviewer();

        public void TakeInterview()
        {
            var interviewer = this.makeInterviewer();

            interviewer.AskQuestions();
        }
    }
}
