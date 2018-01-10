using System;

namespace MediatorPattern.ExamplesForHumans
{
    // Mediator
    class ChatRoom : IChatRoomMediator
    {
        public void ShowMessage(User user, string message)
        {
            var dateTime = DateTime.Now.ToString();

            var sender = user.GetName();

            Console.WriteLine($"{dateTime} [{sender}]: {message}");
        }
    }
}
