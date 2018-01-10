namespace CommandPattern.ExamplesForHumans
{
    // Command
    public class TurnOnCommand : ICommand
    {
        protected Bulb bulb;

        public TurnOnCommand(Bulb bulb)
        {
            this.bulb = bulb;
        }

        public void Execute()
        {
            this.bulb.TurnOn();
        }

        public void Undo()
        {
            this.bulb.TurnOff();
        }

        public void Redo()
        {
            this.Execute();
        }
    }
}
