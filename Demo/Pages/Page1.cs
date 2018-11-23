#region Usings

using EasyConsole;

#endregion

namespace Demo.Pages
{
    internal class Page1 : MenuPage
    {
        #region  .ctor

        public Page1(Program program)
            : base("Page 1",
                   program,
                   new Option("Page 1A",
                              () => program.NavigateTo<Page1A>()),
                   new Option("Page 1B",
                              () => program.NavigateTo<Page1B>()))
        {
        }

        #endregion
    }
}