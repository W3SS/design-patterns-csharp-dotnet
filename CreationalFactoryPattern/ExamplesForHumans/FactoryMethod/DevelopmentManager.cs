namespace FactoryPattern.ExamplesForHumans.FactoryMethod
{
    public class DevelopmentManager : HiringManager
    {
        protected override IInterviewer makeInterviewer()
        {
            return new Developer();
        }
    }
}
