namespace FactoryPattern.ExamplesForHumans.AbstractFactory
{
    // Now we have our abstract factory that would let us make family of related objects 
    // i.e. wooden door factory would create a wooden door and wooden door fitting expert 
    // and iron door factory would create an iron door and iron door fitting expert.
    public interface IAbstractDoorFactory
    {
        IDoor MakeDoor();
        IDoorFittingExpert MakeFittingExpert();
    }
}
