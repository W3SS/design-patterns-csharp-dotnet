using System;

namespace MementoPattern.ExamplesForHumans
{
    public class MementoClient
    {
        public static void Demo()
        {
            var editor = new Editor();

            // Type some stuff
            editor.Type("This is the first sentence.");
            editor.Type("This is second.");

            // Save the state to restore to : This is the first sentence. This is second.
            var saved = editor.Save();

            // Type some more
            editor.Type("And this is third.");

            // Output: Content before Saving
            Console.WriteLine(editor.GetContent()); // This is the first sentence. This is second. And this is third.

            // Restoring to last saved state
            editor.Restore(saved);

            editor.GetContent(); // This is the first sentence. This is second.
        }
    }
}
