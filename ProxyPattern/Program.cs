using ProxyPattern.DynamicProxyForLogging;
using ProxyPattern.DynamicProxyForLogging.Interfaces;
using ProxyPattern.PropertyProxy;
using ProxyPattern.ProtectionProxy;
using ProxyPattern.ProtectionProxy.Interfaces;
using System;

namespace ProxyPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            // PROTECTION PROXY
            ICar car = new CarProxy(new Driver(12)); // 22
            car.Drive();

            // PROPERTY PROXY
            var c = new Creature();
            c.Agility = 10; // c.set_Agility(10) xxxxxxxxxxxxx
                            // c.Agility = new Property<int>(10)
            c.Agility = 10;

            // DYNAMIC PROXY FOR LOGGING
            //var ba = new BankAccount();
            var ba = Log<BankAccount>.As<IBankAccount>();

            ba.Deposit(100);
            ba.Withdraw(50);

            Console.WriteLine(ba);

            Console.ReadLine();
        }
    }
}
