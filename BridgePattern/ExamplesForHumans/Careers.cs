namespace BridgePattern.ExamplesForHumans
{
    public class Careers : IWebPage
    {
        protected ITheme theme;

        public Careers(ITheme theme)
        {
            this.theme = theme;
        }

        public string GetContent()
        {
            return "Careers page in " + this.theme.GetColor();
        }
    }
}
