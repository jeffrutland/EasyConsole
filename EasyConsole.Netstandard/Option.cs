#region Usings

using System;

#endregion

namespace EasyConsole
{
    public class Option
    {
        #region  .ctor

        public Option(string name,
                      Action callback)
        {
            Name = name;
            Callback = callback;
        }

        #endregion

        #region  Properties

        public string Name { get; }
        public Action Callback { get; }

        #endregion

        #region  Public Methods

        public override string ToString() => Name;

        #endregion
    }
}