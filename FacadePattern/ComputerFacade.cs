namespace FacadePattern
{
    public class ComputerFacade
    {
        public Computer Computer;

        public ComputerFacade(Computer computer)
        {
            this.Computer = computer;
        }

        public void TurnOn()
        {
            this.Computer.GetElectricShock();
            this.Computer.MakeSound();
            this.Computer.ShowLoadingScreen();
            this.Computer.Bam();
        }

        public void TurnOff()
        {
            this.Computer.CloseEverything();
            this.Computer.PullCurrent();
            this.Computer.Sooth();
        }
    }
}
