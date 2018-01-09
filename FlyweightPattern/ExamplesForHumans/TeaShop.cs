using System;
using System.Collections.Generic;

namespace FlyweightPattern.ExamplesForHumans
{
    public class TeaShop
    {
        protected Dictionary<int, KarakTea> orders = new Dictionary<int, KarakTea>();
        protected TeaMaker teaMaker;

        public TeaShop(TeaMaker teaMaker)
        {
            this.teaMaker = teaMaker;
        }

        public void TakeOrder(string teaType, int table)
        {
            this.orders[table] = this.teaMaker.Make(teaType);
        }

        public void Serve()
        {
            foreach (var order in this.orders)
            {
                Console.WriteLine("Serving tea to table# " + order.Key);
            }
        }
    }
}
