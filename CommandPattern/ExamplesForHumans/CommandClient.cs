using System;

namespace CommandPattern.ExamplesForHumans
{
    public class CommandClient
    {
        public static void Demo()
        {
            var bulb = new Bulb();

            var turnOn = new TurnOnCommand(bulb);
            var turnOff = new TurnOffCommand(bulb);

            var remote = new RemoteControl();

            remote.Submit(turnOn); // Bulb has been lit!
            remote.Submit(turnOff); // Darkness!

            Console.ReadLine();
        }
    }
}
