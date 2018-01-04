using Autofac;
using MediatorPattern.Chatroom;
using MediatorPattern.Eventbroker;
using System;

namespace MediatorPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            // CHAT ROOM
            //var room = new ChatRoom();

            //var john = new Person("John");
            //var jane = new Person("Jane");

            //room.Join(john);
            //room.Join(jane);

            //john.Say("hi room");
            //jane.Say("oh, hey john");

            //var simon = new Person("Simon");
            //room.Join(simon);
            //simon.Say("hi everyone!");

            //jane.PrivateMessage("Simon", "glad you could join us!");

            // EVENT BROKER
            var cb = new ContainerBuilder();
            cb.RegisterType<EventBroker>().SingleInstance();
            cb.RegisterType<FootballCoach>();
            cb.RegisterType<Ref>();
            cb.Register((c, p) => new FootballPlayer(c.Resolve<EventBroker>(), p.Named<string>("name")));

            using (var c = cb.Build())
            {
                var referee = c.Resolve<Ref>(); // order matters here!
                var coach = c.Resolve<FootballCoach>();
                var player1 = c.Resolve<FootballPlayer>(new NamedParameter("name", "John"));
                var player2 = c.Resolve<FootballPlayer>(new NamedParameter("name", "Chris"));
                player1.Score();
                player1.Score();
                player1.Score(); // only 2 notifications
                player1.AssaultReferee();
                player2.Score();
            }

            Console.ReadLine();
        }
    }
}
