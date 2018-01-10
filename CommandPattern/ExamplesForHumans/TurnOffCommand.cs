namespace CommandPattern.ExamplesForHumans
{
    // Command
    public class TurnOffCommand : ICommand
    {
        protected Bulb bulb;

        public TurnOffCommand(Bulb bulb)
        {
            this.bulb = bulb;
        }

        public void Execute()
        {
            this.bulb.TurnOff();
        }

        public void Undo()
        {
            this.bulb.TurnOn();
        }

        public void Redo()
        {
            this.Execute();
        }
    }
}
