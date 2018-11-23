namespace EasyConsole
{
    public abstract class MenuPage : Page
    {
        #region  .ctor

        protected MenuPage(string title,
                        Program program,
                        params Option[] options)
            : base(title,
                   program)
        {
            Menu = new Menu();

            foreach (var option in options)
            {
                Menu.Add(option);
            }
        }

        #endregion

        #region Internal Properties

        protected Menu Menu { get; set; }

        #endregion

        #region  Public Methods

        public override void Display()
        {
            base.Display();

            if (Program.NavigationEnabled && !Menu.Contains("Go back"))
            {
                Menu.Add("Go back",
                         () => Program.NavigateBack());
            }

            Menu.Display();
        }

        #endregion
    }
}