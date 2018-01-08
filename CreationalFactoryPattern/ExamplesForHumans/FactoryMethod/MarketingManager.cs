namespace FactoryPattern.ExamplesForHumans.FactoryMethod
{
    public class MarketingManager : HiringManager
    {
        protected override IInterviewer MakeInterviewer()
        {
            return new CommunityExecutive();
        }
    }
}
