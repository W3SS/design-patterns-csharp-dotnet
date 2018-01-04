using ProxyPattern.ProtectionProxy.Interfaces;
using System;

namespace ProxyPattern.ProtectionProxy
{
    public class Car : ICar
    {
        public void Drive()
        {
            Console.WriteLine("Car being driven");
        }
    }
}
