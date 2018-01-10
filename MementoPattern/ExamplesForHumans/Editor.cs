namespace MementoPattern.ExamplesForHumans
{
    class Editor
    {
        protected string content = "";

        public void Type(string words)
        {
            this.content = this.content + " " + words;
        }

        public string GetContent()
        {
            return this.content;
        }

        public EditorMemento Save()
        {
            return new EditorMemento(this.content);
        }

        public void Restore(EditorMemento memento)
        {
            this.content = memento.GetContent();
        }
    }
}
