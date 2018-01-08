namespace FactoryPattern.ExamplesForHumans.AbstractFactory
{
    // Iron door factory to get iron door and the relevant fitting expert
    public class IronDoorFactory : IAbstractDoorFactory
    {
        public IDoor MakeDoor()
        {
            return new IronDoor();
        }

        public IDoorFittingExpert MakeFittingExpert()
        {
            return new Welder();
        }
    }
}
