using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern.ExamplesForHumans.AbstractFactory
{
    public class IronDoor : IDoor
    {
        public void GetDescription()
        {
            Console.WriteLine("I am an iron door");
        }
    }
}
