using System;

namespace ChainOfResponsibilityPattern.ExamplesForHumans
{
    public class ChainOfResponsibilityClient
    {
        public static void Demo()
        {
            // Let's prepare a chain like below
            //      bank->paypal->bitcoin
            //
            // First priority bank
            //      If bank can't pay then paypal
            //      If paypal can't pay then bit coin

            var bank = new Bank("Bank", 100);          // Bank with balance 100
            var paypal = new Paypal("Paypal", 200);      // Paypal with balance 200
            var bitcoin = new Bitcoin("Bitcoin", 300);    // Bitcoin with balance 300

            bank.SetNext(paypal);
            paypal.SetNext(bitcoin);

            // Let's try to pay using the first priority i.e. bank

            bank.Pay(259);

            // Output will be
            // ==============
            // Cannot pay using bank. Proceeding ..
            // Cannot pay using paypal. Proceeding ..:
            // Paid 259 using Bitcoin!

            Console.ReadLine();
        }
    }
}
