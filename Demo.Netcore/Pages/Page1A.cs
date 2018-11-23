#region Usings

using EasyConsole;

#endregion

namespace Demo.Netcore.Pages
{
    internal class Page1A : MenuPage
    {
        #region  .ctor

        public Page1A(Program program)
            : base("Page 1A",
                   program,
                   new Option("Page 1Ai",
                              () => program.NavigateTo<Page1Ai>()))
        {
        }

        #endregion
    }
}