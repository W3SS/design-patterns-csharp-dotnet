namespace TemplateMethodPattern.ExampleForHumans
{
    public abstract class Builder
    {
        // Template method
        public void Build()
        {
            this.Test();
            this.Lint();
            this.Assemble();
            this.Deploy();
        }

        public abstract void Test();
        public abstract void Lint();
        public abstract void Assemble();
        public abstract void Deploy();
    }
}
