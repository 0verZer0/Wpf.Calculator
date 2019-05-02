using System.ComponentModel;

namespace Calculator.MVVM.Core
{
    public abstract class BaseViewModel : INotifyPropertyChanged
    {
        #region Event
        public event PropertyChangedEventHandler PropertyChanged;
        #endregion

        #region Method
        public void Notify(string prop)
        {
            var handler = PropertyChanged;
            if (handler != null)
                handler.Invoke(this, new PropertyChangedEventArgs(prop));
        }
        #endregion
    }
}
