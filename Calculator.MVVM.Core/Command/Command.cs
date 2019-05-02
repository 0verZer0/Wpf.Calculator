using System;
using System.Windows.Input;

namespace Calculator.MVVM.Core
{
    public class Command : ICommand
    {
        #region Event
        public event EventHandler CanExecuteChanged;
        #endregion

        #region Member
        private Action mAction;
        #endregion

        #region Contructor
        public Command(Action action)
        {
            mAction = action;
        }
        #endregion

        #region Method
        public bool CanExecute(object parameter)
        {
            return true;
        }
        public void Execute(object parameter)
        {
            mAction();
        }
        #endregion
    }
}
