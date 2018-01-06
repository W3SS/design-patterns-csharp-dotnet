using System;

namespace TemplateMethodPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var chess = new Chess();
            chess.Run();

            Console.ReadLine();
        }
    }
}
