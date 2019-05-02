using System;
using System.Data;

namespace Calculator.MVVM.Core.ViewModel
{
    public class MainWindowViewModel : BaseViewModel
    {
        #region Property
        public string Calculation
        {
            get { return mCalculation; }
            set
            {
                mCalculation = value;
                Notify(nameof(Calculation));
            }
        }
        #endregion

        #region Member
        private string mCalculation;
        #endregion

        #region Command
        public Command Write1Command { get; set; }
        public Command Write2Command { get; set; }
        public Command Write3Command { get; set; }
        public Command Write4Command { get; set; }
        public Command Write5Command { get; set; }
        public Command Write6Command { get; set; }
        public Command Write7Command { get; set; }
        public Command Write8Command { get; set; }
        public Command Write9Command { get; set; }
        public Command Write0Command { get; set; }
        public Command ClearCommand { get; set; }
        public Command CalculateCommand { get; set; }
        public Command DivideCommand { get; set; }
        public Command MultiplyCommand { get; set; }
        public Command SubtractCommand { get; set; }
        public Command AddCommand { get; set; }
        #endregion

        #region Constructor
        public MainWindowViewModel()
        {
            mCalculation = string.Empty;

            Write1Command = new Command(Write1);
            Write2Command = new Command(Write2);
            Write3Command = new Command(Write3);
            Write4Command = new Command(Write4);
            Write5Command = new Command(Write5);
            Write6Command = new Command(Write6);
            Write7Command = new Command(Write7);
            Write8Command = new Command(Write8);
            Write9Command = new Command(Write9);
            Write0Command = new Command(Write0);

            ClearCommand = new Command(Clear);
            CalculateCommand = new Command(Calculate);

            DivideCommand = new Command(Divide);
            MultiplyCommand = new Command(Multiply);
            SubtractCommand = new Command(Subtract);
            AddCommand = new Command(Add);
        }
        #endregion

        #region Method
        private void Write1()
        {
            Calculation += "1";
        }
        private void Write2()
        {
            Calculation += "2";
        }
        private void Write3()
        {
            Calculation += "3";
        }
        private void Write4()
        {
            Calculation += "4";
        }
        private void Write5()
        {
            Calculation += "5";
        }
        private void Write6()
        {
            Calculation += "6";
        }
        private void Write7()
        {
            Calculation += "7";
        }
        private void Write8()
        {
            Calculation += "8";
        }
        private void Write9()
        {
            Calculation += "9";
        }
        private void Write0()
        {
            Calculation += "0";
        }
        private void Clear()
        {
            Calculation = string.Empty;
        }
        private void Calculate()
        {
            try
            {
                var data = new DataTable();
                Calculation = data.Compute(Calculation, string.Empty).ToString();
            }
            catch (Exception)
            {
                Clear();
            }
        }
        private void Divide()
        {
            Calculation += "/";
        }
        private void Multiply()
        {
            Calculation += "*";
        }
        private void Subtract()
        {
            Calculation += "-";
        }
        private void Add()
        {
            Calculation += "+";
        }
        #endregion
    }
}
