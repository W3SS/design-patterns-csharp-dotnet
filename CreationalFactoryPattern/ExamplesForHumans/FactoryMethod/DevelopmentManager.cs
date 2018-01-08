namespace FactoryPattern.ExamplesForHumans.FactoryMethod
{
    public class DevelopmentManager : HiringManager
    {
        protected override IInterviewer MakeInterviewer()
        {
            return new Developer();
        }
    }
}
