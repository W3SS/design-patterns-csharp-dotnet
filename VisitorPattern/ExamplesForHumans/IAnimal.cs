namespace VisitorPattern.ExamplesForHumans
{
    // Visitee
    public interface IAnimal
    {
        void Accept(IAnimalOperation operation);
    }
}
