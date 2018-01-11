using System;

namespace StatePattern.ExamplesForHumans
{
    public class StateClient
    {
        public static void Demo()
        {
            var editor = new TextEditor(new Default());

            editor.Type("First line");

            editor.SetState(new UpperCase());

            editor.Type("Second line");
            editor.Type("Third line");

            editor.SetState(new LowerCase());

            editor.Type("Fourth line");
            editor.Type("Fifth line");

            // Output:
            // First line
            // SECOND LINE
            // THIRD LINE
            // fourth line
            // fifth line

            Console.ReadLine();
        }
    }
}
