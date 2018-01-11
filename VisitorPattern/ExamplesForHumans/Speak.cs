namespace VisitorPattern.ExamplesForHumans
{
    public class Speak : IAnimalOperation
    {
        public void VisitMonkey(Monkey monkey)
        {
            monkey.Shout();
        }

        public void VisitLion(Lion lion)
        {
            lion.Roar();
        }

        public void VisitDolphin(Dolphin dolphin)
        {
            dolphin.Speak();
        }
    }
}
