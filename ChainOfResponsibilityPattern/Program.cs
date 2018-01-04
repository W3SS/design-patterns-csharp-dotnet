using ChainOfResponsibilityPattern.BrokerChain;
using ChainOfResponsibilityPattern.MethodChain;
using System;

namespace ChainOfResponsibilityPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            // METHOD CHAIN
            var goblin = new Creature("Goblin", 2, 2);

            Console.WriteLine(goblin);

            var root = new CreatureModifier(goblin);

            root.Add(new NoBonusesModifier(goblin));

            Console.WriteLine("Let's double goblin's attack...");

            root.Add(new DoubleAttackModifier(goblin));

            Console.WriteLine("Let's increase goblin's defense");

            root.Add(new IncreaseDefenseModifier(goblin));

            // eventually...
            root.Handle();

            Console.WriteLine(goblin);

            // BROKER CHAIN
            var game = new Game();
            var goblinBc = new CreatureBC(game, "Strong Goblin", 3, 3);

            Console.WriteLine(goblinBc);

            using (new DoubleAttackModifierBC(game, goblinBc))
            {
                Console.WriteLine(goblinBc);

                using (new IncreaseDefenseModifierBC(game, goblinBc))
                {
                    Console.WriteLine(goblinBc);
                }
            }

            Console.WriteLine(goblinBc);

            Console.ReadLine();
        }
    }
}
