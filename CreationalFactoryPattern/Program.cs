using FactoryPattern.AbstractFactory;
using FactoryPattern.AbstractFactory.Interfaces;
using System;

namespace FactoryPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            //var p1 = new Point(2, 3, Point.CoordinateSystem.Cartesian);
            //var origin = Point.Origin;

            //var p2 = Point.Factory.NewCartesianPoint(1, 2);

            // ABSTRACT FACTORY
            var machine = new HotDrinkMachine();
            //var drink = machine.MakeDrink(HotDrinkMachine.AvailableDrink.Tea, 300);
            //drink.Consume();

            IHotDrink drink = machine.MakeDrink();
            drink.Consume();

            Console.ReadLine();
        }
    }
}
