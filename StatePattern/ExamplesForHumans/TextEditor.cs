namespace StatePattern.ExamplesForHumans
{
    class TextEditor
    {
        protected IWritingState state;

        public TextEditor(IWritingState state)
        {
            this.state = state;
        }

        public void SetState(IWritingState state)
        {
            this.state = state;
        }

        public void Type(string words)
        {
            this.state.Write(words);
        }
    }
}
