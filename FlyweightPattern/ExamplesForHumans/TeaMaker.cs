using System.Collections.Generic;

namespace FlyweightPattern.ExamplesForHumans
{
    // Acts as a factory and saves the tea
    public class TeaMaker
    {
        protected Dictionary<string, KarakTea> availableTea = new Dictionary<string, KarakTea>();

        public KarakTea Make(string preference)
        {
            if (!this.availableTea.ContainsKey(preference))
            {
                this.availableTea.Add(preference, new KarakTea());
            }

            return this.availableTea[preference];
        }
    }
}
