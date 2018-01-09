using System;

namespace FacadePattern.ExamplesForHumans
{
    public class Computer
    {
        public void GetElectricShock()
        {
            Console.WriteLine("Ouch!");
        }

        public void MakeSound()
        {
            Console.WriteLine("Beep beep!");
        }

        public void ShowLoadingScreen()
        {
            Console.WriteLine("Loading..");
        }

        public void Bam()
        {
            Console.WriteLine("Ready to be used!");
        }

        public void CloseEverything()
        {
            Console.WriteLine("Bup bup bup buzzzz!");
        }

        public void Sooth()
        {
            Console.WriteLine("Zzzzz");
        }

        public void PullCurrent()
        {
            Console.WriteLine("Haaah!");
        }
    }
}
