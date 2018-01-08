using System;

namespace BridgePattern.ExamplesForHumans
{
    public class BridgeClient
    {
        static void Demo()
        {
            var darkTheme = new DarkTheme();

            var about = new About(darkTheme);
            var careers = new Careers(darkTheme);

            Console.WriteLine(about.GetContent()); // "About page in Dark Black";
            Console.WriteLine(careers.GetContent()); // "Careers page in Dark Black";

            Console.ReadLine();
        }
    }
}
