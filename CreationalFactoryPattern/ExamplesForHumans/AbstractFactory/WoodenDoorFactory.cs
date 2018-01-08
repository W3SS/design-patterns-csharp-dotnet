namespace FactoryPattern.ExamplesForHumans.AbstractFactory
{
    // Wooden factory to return carpenter and wooden door
    public class WoodenDoorFactory : IAbstractDoorFactory
    {
        public IDoor MakeDoor()
        {
            return new WoodenDoor();
        }

        public IDoorFittingExpert MakeFittingExpert()
        {
            return new Carpenter();
        }
    }
}
