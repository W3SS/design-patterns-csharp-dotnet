using System;

namespace ProxyPattern.ExamplesForHumans
{
    public class SecurityProxy
    {
        protected IDoor door;

        public SecurityProxy(IDoor door)
        {
            this.door = door;
        }

        public void Open(string password)
        {
            if (this.Authenticate(password)) 
            {
                this.door.Open();
            } 
            else 
            {
                Console.WriteLine("Big no! It ain't possible.");
            }
        }

        public bool Authenticate(string password)
        {
            return password == "$ecr@t";
        }

        public void Close()
        {
            this.door.Close();
        }
    }
}
