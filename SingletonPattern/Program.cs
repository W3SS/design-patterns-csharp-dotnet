using Autofac;
using SingletonPattern.MonoStatePattern;
using SingletonPattern.Singleton;
using SingletonPattern.SingletonInDI;
using System;

namespace SingletonPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            // SINGLETON PATTERN
            var db = SingletonDatabase.Instance;

            // works just fine while you're working with a real database.
            var city = "Tokyo";
            Console.WriteLine($"{city} has population {db.GetPopulation(city)}");

            // now some tests

            // SINGLETON IN DI - SOCIALLY ACCEPTABLE
            var builder = new ContainerBuilder();

            builder.RegisterType<EventBroker>().SingleInstance();
            builder.RegisterType<Foo>();

            using (var c = builder.Build())
            {
                var foo1 = c.Resolve<Foo>();
                var foo2 = c.Resolve<Foo>();

                Console.WriteLine(ReferenceEquals(foo1, foo2));
                Console.WriteLine(ReferenceEquals(foo1.Broker, foo2.Broker));
            }

            // MONOSTATE PATTERN
            var ceo = new ChiefExecutiveOfficer();
            ceo.Name = "Adam Smith";
            ceo.Age = 55;

            var ceo2 = new ChiefExecutiveOfficer();
            Console.WriteLine(ceo2);

            Console.ReadLine();
        }
    }
}
