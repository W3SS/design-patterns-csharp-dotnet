namespace ChainOfResponsibilityPattern.ExamplesForHumans
{
    public class Paypal : Account
    {
        public Paypal(string accountName, float balance)
            : base(accountName, balance)
        {
        }
    }
}
