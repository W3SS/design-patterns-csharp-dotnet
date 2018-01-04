using System;
using System.Linq;
using System.Reactive.Linq;

namespace MediatorPattern.Eventbroker
{
    public class Ref : Actor
    {
        public Ref(EventBroker broker) : base(broker)
        {
            broker.OfType<PlayerEvent>()
              .Subscribe(e =>
              {
                  if (e is PlayerScoredEvent scored)
                  {
                      Console.WriteLine($"REF: player {scored.Name} has scored his {scored.GoalsScored} goal.");
                  }

                  if (e is PlayerSentOffEvent sentOff)
                  {
                      Console.WriteLine($"REF: player {sentOff.Name} sent off due to {sentOff.Reason}.");
                  }
              });
        }
    }
}
