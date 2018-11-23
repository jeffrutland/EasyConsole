#region Usings

using EasyConsole;

#endregion

namespace Demo.Netcore.Pages
{
    internal class Page2 : Page
    {
        #region  .ctor

        public Page2(Program program)
            : base("Page 2",
                   program)
        {
        }

        #endregion

        #region  Public Methods

        public override void Display()
        {
            base.Display();

            Output.WriteLine("Hello from Page 2");

            Input.ReadString("Press [Enter] to navigate home");
            Program.NavigateHome();
        }

        #endregion
    }
}