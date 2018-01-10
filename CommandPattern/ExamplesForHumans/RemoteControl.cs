namespace CommandPattern.ExamplesForHumans
{
    // Invoker
    class RemoteControl
    {
        public void Submit(ICommand command)
        {
            command.Execute();
        }
    }
}
