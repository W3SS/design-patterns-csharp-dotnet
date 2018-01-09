namespace FacadePattern.ExamplesForHumans
{
    public class ComputerFacade
    {
        protected Computer computer;

        public ComputerFacade(Computer computer)
        {
            this.computer = computer;
        }

        public void TurnOn()
        {
            this.computer.GetElectricShock();
            this.computer.MakeSound();
            this.computer.ShowLoadingScreen();
            this.computer.Bam();
        }

        public void TurnOff()
        {
            this.computer.CloseEverything();
            this.computer.PullCurrent();
            this.computer.Sooth();
        }
    }
}
