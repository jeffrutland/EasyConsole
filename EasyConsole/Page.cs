#region Usings

using System;
using System.Linq;

#endregion

namespace EasyConsole
{
    public abstract class Page
    {
        #region  .ctor

        protected Page(string title,
                    Program program)
        {
            Title = title;
            Program = program;
        }

        #endregion

        #region  Properties

        public string Title { get; }

        public Program Program { get; set; }

        #endregion

        #region  Public Methods

        public virtual void Display()
        {
            if (Program.History.Count > 1 && Program.BreadcrumbHeader)
            {
                string breadcrumb = null;
                foreach (var title in Program.History.Select(page => page.Title).Reverse())
                {
                    breadcrumb += title + " > ";
                }

                if (breadcrumb != null)
                {
                    breadcrumb = breadcrumb.Remove(breadcrumb.Length - 3);
                    Console.WriteLine(breadcrumb);
                }
            }
            else
            {
                Console.WriteLine(Title);
            }

            Console.WriteLine("---");
        }

        #endregion
    }
}