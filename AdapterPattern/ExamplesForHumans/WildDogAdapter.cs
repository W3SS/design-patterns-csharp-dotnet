namespace AdapterPattern.ExamplesForHumans
{
    // Adapter around wild dog to make it compatible with our game
    public class WildDogAdapter : ILion
    {
        protected WildDog dog;

        public WildDogAdapter(WildDog dog)
        {
            this.dog = dog;
        }
        
        public void Roar()
        {
            this.dog.Bark();
        }
    }
}
