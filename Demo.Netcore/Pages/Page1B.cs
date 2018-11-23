#region Usings

using EasyConsole;

#endregion

namespace Demo.Netcore.Pages
{
    internal class Page1B : Page
    {
        #region  .ctor

        public Page1B(Program program)
            : base("Page 1B",
                   program)
        {
        }

        #endregion

        #region  Public Methods

        public override void Display()
        {
            base.Display();

            Output.WriteLine("Hello from Page 1B");

            Input.ReadString("Press [Enter] to navigate home");
            Program.NavigateHome();
        }

        #endregion
    }
}