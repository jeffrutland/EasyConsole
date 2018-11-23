#region Usings

using EasyConsole;

#endregion

namespace Demo.Netcore.Pages
{
    internal class Page1Ai : Page
    {
        #region  .ctor

        public Page1Ai(Program program)
            : base("Page 1Ai",
                   program)
        {
        }

        #endregion

        #region  Public Methods

        public override void Display()
        {
            base.Display();

            Output.WriteLine("Hello from Page 1Ai");

            Input.ReadString("Press [Enter] to navigate home");
            Program.NavigateHome();
        }

        #endregion
    }
}