#region Usings

using System;
using EasyConsole;

#endregion

namespace Demo.Netcore.Pages
{
    internal class InputPage : Page
    {
        #region  .ctor

        public InputPage(Program program)
            : base("Input",
                   program)
        {
        }

        #endregion

        #region  Public Methods

        public override void Display()
        {
            base.Display();

            Fruit input = Input.ReadEnum<Fruit>("Select a fruit");
            Output.WriteLine(ConsoleColor.Green,
                             "You selected {0}",
                             input);

            Input.ReadString("Press [Enter] to navigate home");
            Program.NavigateHome();
        }

        #endregion
    }

    internal enum Fruit
    {
        Apple,
        Banana,
        Coconut
    }
}