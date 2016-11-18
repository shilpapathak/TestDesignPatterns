using System.Collections.Generic;

namespace Factory
{
    abstract class Page
    {
    }

    class SkillPage : Page
    {
        
    }
    class EducationPage : Page
    {

    }

    class ExperiencePage : Page
    {

    }

    class IntroductionPage : Page
    {

    }

    class ResultPage : Page
    {

    }

    class ConclusionPage : Page
    {

    }

    class SummaryPage : Page
    {

    }

    class BibliographyPage : Page
    {

    }

    abstract class Document
    {
        private readonly List<Page> _pages = new List<Page>();

        public Document()
        {
            this.CreatePages();
        }

        public List<Page> Pages
        {
            get { return _pages; } 
        }

        public abstract void CreatePages();
    }

    class Resume : Document
    {
        public override void CreatePages()
        {
            Pages.Add(new SkillPage());
            Pages.Add(new ExperiencePage());
            Pages.Add(new EducationPage());
        }
    }

    class Report : Document
    {
        public override void CreatePages()
        {
            Pages.Add(new BibliographyPage());
            Pages.Add(new ResultPage());
            Pages.Add(new ConclusionPage());
            Pages.Add(new SummaryPage());
            Pages.Add(new ResultPage());
        }
    }
}
