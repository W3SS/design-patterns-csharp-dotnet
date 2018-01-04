namespace CommandPattern.Interfaces
{
    public interface ICommand
    {
        void Call();
        void Undo();
    }
}
