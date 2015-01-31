using System;
using System.Collections.Generic;

namespace FactoryMethod
{
    public abstract class Document
    {
        private readonly List<Page> pages;

        public Document()
        {
            this.pages = new List<Page>();
            this.CreatePages();
        }

        public List<Page> Pages
        {
            get { return this.pages; }
        }

        public void ShowPages()
        {
            Console.WriteLine("The {0} document has the following pages", this.GetType().Name);
            foreach (var page in this.Pages)
            {
                Console.WriteLine("- {0}", page.GetType().Name);
            }

            Console.WriteLine();
            Console.WriteLine();
        }

        protected abstract void CreatePages();
    }
}