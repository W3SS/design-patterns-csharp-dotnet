namespace FactoryPattern
{
    public class Person
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public Person(int id, string name)
        {
            this.Id = id;
            this.Name = name;
        }
    }

    public class PersonFactory
    {
        private int index = -1;

        public Person CreatePerson(string name)
        {
            return new Person(++index, name);
        }
    }

    class FactoryPatternExercise
    {
    }
}
