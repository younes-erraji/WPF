using System;

using System.Windows;
using System.Windows.Input;

namespace WPF_Demo.Views.Commands.Custom
{
    /// <summary>
    /// Interaction logic for CustomCommand.xaml
    /// </summary>
    public partial class CustomCommand : Window
    {
        
        public CustomCommand()
        {
            InitializeComponent();

            ButtonReverse.Command = ReverseCommand.Reverse;

            CommandBinding binding = new CommandBinding();
            binding.Command = ReverseCommand.Reverse;
            binding.Executed += ReverseString_Executed;
            binding.CanExecute += ReverseString_CanExecute;

            CommandBindings.Add(binding);
        }

        private void ReverseString_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            char[] temp = txtBox.Text.ToCharArray();
            Array.Reverse(temp);
            txtBox.Text = new string(temp);
        }

        private void ReverseString_CanExecute(object sender, CanExecuteRoutedEventArgs e)
        {
            e.CanExecute = txtBox.Text.Length > 0;
        }
    }
}
