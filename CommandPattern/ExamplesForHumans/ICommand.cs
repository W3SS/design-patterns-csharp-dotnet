namespace CommandPattern.ExamplesForHumans
{
    // Interface that each of the commands are going to implement
    public interface ICommand
    {
        void Execute();
        void Undo();
        void Redo();
    }
}
