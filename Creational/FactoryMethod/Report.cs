namespace FactoryMethod
{
    public class Report : Document
    {
        protected override void CreatePages()
        {
            this.Pages.Add(new ConclusionPage());
        }
    }
}