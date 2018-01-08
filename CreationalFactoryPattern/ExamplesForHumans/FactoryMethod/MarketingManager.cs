namespace FactoryPattern.ExamplesForHumans.FactoryMethod
{
    public class MarketingManager : HiringManager
    {
        protected override IInterviewer makeInterviewer()
        {
            return new CommunityExecutive();
        }
    }
}
