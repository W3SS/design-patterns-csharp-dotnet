namespace MementoPattern.ExamplesForHumans
{
    public class EditorMemento
    {
        protected string content;

        public EditorMemento(string content)
        {
            this.content = content;
        }

        public string GetContent()
        {
            return this.content;
        }
    }
}
