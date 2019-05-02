using System;
using System.Data;
using System.Windows;
using System.Windows.Controls;

namespace Calculator
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            var current = (Button)sender;
            textbox.Text += current.Content;
        }

        private void buttonClear_Click(object sender, RoutedEventArgs e)
        {
            textbox.Text = string.Empty;
        }

        private void buttonEquals_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                var data = new DataTable();
                textbox.Text = data.Compute(textbox.Text, string.Empty).ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
