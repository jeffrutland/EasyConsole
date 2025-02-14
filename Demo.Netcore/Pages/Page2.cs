﻿using EasyConsole;

namespace Demo.Netcore.Pages
{
    internal class Page2 : Page
    {
        public Page2(Program program) : base("Page 2", program)
        {
        }

        public override void Display()
        {
            base.Display();

            Output.WriteLine("Hello from Page 2");

            Input.ReadString("Press [Enter] to navigate home");
            Program.NavigateHome();
        }
    }
}