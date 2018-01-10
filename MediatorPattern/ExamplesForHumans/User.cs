namespace MediatorPattern.ExamplesForHumans
{
    public class User
    {
        protected string name;
        protected IChatRoomMediator chatMediator;

        public User(string name, IChatRoomMediator chatMediator)
        {
            this.name = name;
            this.chatMediator = chatMediator;
        }

        public string GetName()
        {
            return this.name;
        }

        public void Send(string message)
        {
            this.chatMediator.ShowMessage(this, message);
        }
    }
}
