using System;

namespace FacadePattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var computer = new ComputerFacade(new Computer());

            computer.TurnOn(); // Ouch! Beep beep! Loading.. Ready to be used!
            computer.TurnOff(); // Bup bup buzzz! Haah! Zzzzz

            Console.ReadLine();
        }
    }
}
