namespace SingletonPattern.ExamplesForHumans
{
    public sealed class President
    {
        private static President _instance;

        private President()
        {
            // Hide the constructor
        }

        public static President GetInstance()
        {
            if (_instance == null) 
            {
                _instance = new President();
            }

            return _instance;
        }
        
    }
}
