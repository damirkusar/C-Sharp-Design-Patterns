namespace FactoryMethod
{
    public class Resume : Document
    {
        protected override void CreatePages()
        {
            this.Pages.Add(new SkillPage());
            this.Pages.Add(new EducationPage());
            this.Pages.Add(new ExperiencePage());
        }
    }
}