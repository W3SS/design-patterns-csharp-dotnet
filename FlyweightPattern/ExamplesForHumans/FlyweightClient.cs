using System;

namespace FlyweightPattern.ExamplesForHumans
{
    public class FlyweightClient
    {
        public static void Demo()
        {
            var teaMaker = new TeaMaker();
            var shop = new TeaShop(teaMaker);

            shop.TakeOrder("less sugar", 1);
            shop.TakeOrder("more milk", 2);
            shop.TakeOrder("without sugar", 5);

            shop.Serve();

            // Serving tea to table# 1
            // Serving tea to table# 2
            // Serving tea to table# 5

            Console.ReadLine();
        }
    }
}
