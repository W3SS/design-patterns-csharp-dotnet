using System;
using System.Linq;
using System.Reactive.Linq;

namespace MediatorPattern.Eventbroker
{
    public class FootballCoach : Actor
    {
        public FootballCoach(EventBroker broker) : base(broker)
        {
            broker.OfType<PlayerScoredEvent>()
              .Subscribe(
                ps =>
                {
                    if (ps.GoalsScored < 3)
                        Console.WriteLine($"Coach: well done, {ps.Name}!");
                }
              );

            broker.OfType<PlayerSentOffEvent>()
              .Subscribe(
                ps =>
                {
                    if (ps.Reason == "violence")
                        Console.WriteLine($"Coach: How could you, {ps.Name}?");
                });
        }
    }
}
