namespace ChainOfResponsibilityPattern.ExamplesForHumans
{
    public class Bank : Account
    {
        public Bank(string accountName, float balance)
            : base(accountName, balance)
        {
        }
    }
}
