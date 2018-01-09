using System;

namespace FacadePattern.ExamplesForHumans
{
    public class FacadeClient
    {
        static void Demo()
        {
            var computer = new ComputerFacade(new Computer());

            computer.TurnOn(); // Ouch! Beep beep! Loading.. Ready to be used!
            computer.TurnOff(); // Bup bup buzzz! Haah! Zzzzz

            Console.ReadLine();
        }
    }
}
