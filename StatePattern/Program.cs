using Stateless;
using StatePattern.HandMadeStateMachine;
using StatePattern.Stateless;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;

namespace StatePattern
{
    class Program
    {
        private static Dictionary<State, List<(Trigger, State)>> rules
      = new Dictionary<State, List<(Trigger, State)>>
      {
          [State.OffHook] = new List<(Trigger, State)>
        {
          (Trigger.CallDialed, State.Connecting)
        },
          [State.Connecting] = new List<(Trigger, State)>
        {
          (Trigger.HungUp, State.OffHook),
          (Trigger.CallConnected, State.Connected)
        },
          [State.Connected] = new List<(Trigger, State)>
        {
          (Trigger.LeftMessage, State.OffHook),
          (Trigger.HungUp, State.OffHook),
          (Trigger.PlacedOnHold, State.OnHold)
        },
          [State.OnHold] = new List<(Trigger, State)>
        {
          (Trigger.TakenOffHold, State.Connected),
          (Trigger.HungUp, State.OffHook)
        }
      };

        static void Main(string[] args)
        {
            // HAND MADE STATE MACHINE
            //var state = State.OffHook;

            //while (true)
            //{
            //    Console.WriteLine($"The phone is currently {state}");
            //    Console.WriteLine("Select a trigger:");

            //    // foreach to for
            //    for (var i = 0; i < rules[state].Count; i++)
            //    {
            //        var (t, _) = rules[state][i];
            //        Console.WriteLine($"{i}. {t}");
            //    }


            //    int input = int.Parse(Console.ReadLine());

            //    var (_, s) = rules[state][input];
            //    state = s;
            //}

            // STATELESS
            var stateMachine = new StateMachine<Health, Activity>(Health.NonReproductive);

            stateMachine.Configure(Health.NonReproductive)
              .Permit(Activity.ReachPuberty, Health.Reproductive);

            stateMachine.Configure(Health.Reproductive)
              .Permit(Activity.Historectomy, Health.NonReproductive)
              .PermitIf(Activity.HaveUnprotectedSex, Health.Pregnant,
                () => ParentsNotWatching);

            stateMachine.Configure(Health.Pregnant)
              .Permit(Activity.GiveBirth, Health.Reproductive)
              .Permit(Activity.HaveAbortion, Health.Reproductive);

        }

        public static bool ParentsNotWatching
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    }
}
