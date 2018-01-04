using ObserverPattern.Events;
using ObserverPattern.ObserverPattern;
using ObserverPattern.WeakEventPattern;
using System;
using System.ComponentModel;

namespace ObserverPattern
{
    class Program
    {
        static void Main()
        {
            //// EVENTS

            //var person = new Person();

            //person.FallsIll += CallDoctor;

            //person.CatchACold();

            ////WEAK EVENT PATTERN

            //var btn = new Button();

            //var window = new Window2(btn);
            ////var window = new Window(btn);

            //var windowRef = new WeakReference(window);

            //btn.Fire();

            //Console.WriteLine("Setting window to null");

            //window = null;

            //FireGC();

            //Console.WriteLine($"Is window alive after GC? {windowRef.IsAlive}");

            //btn.Fire();

            //Console.WriteLine("Setting button to null");

            //btn = null;

            //FireGC();

            // OBSERVER PATTERN

            Market market = new Market();

            //      market.PriceAdded += (sender, eventArgs) =>
            //      {
            //        Console.WriteLine($"Added price {eventArgs.Price}");
            //      };
            //      market.AddPrice(123);

            market.Prices.ListChanged += (sender, eventArgs) => // Subscribe
            {
                if (eventArgs.ListChangedType == ListChangedType.ItemAdded)
                {
                    Console.WriteLine($"Added price {((BindingList<float>)sender)[eventArgs.NewIndex]}");
                }
            };
            market.AddPrice(123);

            // 1) How do we know when a new item becomes available?

            // 2) how do we know when the market is done supplying items?
            // maybe you are trading a futures contract that expired and there will be no more prices

            // 3) What happens if the market feed is broken?

            Console.ReadLine();
        }

        private static void FireGC()
        {
            Console.WriteLine("Starting GC");

            GC.Collect();

            GC.WaitForPendingFinalizers();

            GC.Collect();

            Console.WriteLine("GC is done!");
        }

        private static void CallDoctor(object sender, FallsIllEventArgs eventArgs)
        {
            Console.WriteLine($"A doctor has been called to {eventArgs.Address}");
        }
    }
}
