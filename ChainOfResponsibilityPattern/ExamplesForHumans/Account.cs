using System;

namespace ChainOfResponsibilityPattern.ExamplesForHumans
{
    public abstract class Account
    {
        protected string accountName;
        protected Account successor;
        protected float balance;

        public Account(string accountName, float balance)
        {
            this.accountName = accountName;
            this.balance = balance;
        }

        public void SetNext(Account account)
        {
            this.successor = account;
        }

        public void Pay(float amountToPay)
        {
            if (this.CanPay(amountToPay)) 
            {
                Console.WriteLine($"Paid {amountToPay} using {accountName}");
            }
            else if(this.successor != null) 
            {
                Console.WriteLine($"Cannot pay using {accountName}. Proceeding ..");

                this.successor.Pay(amountToPay);
            } 
            else 
            {
                throw new Exception("None of the accounts have enough balance");
            }
        }

        public bool CanPay(float amount)
        {
            return this.balance >= amount;
        }
    }
}
