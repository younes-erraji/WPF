using System;
using System.Windows;
using System.Windows.Data;
using System.Windows.Controls;

namespace WPF_Demo.Views.Bindings
{
    /// <summary>
    /// Interaction logic for TriggersBindingWindow.xaml
    /// </summary>
    public partial class TriggersBindingWindow : Window
    {
        public TriggersBindingWindow()
        {
            InitializeComponent();
        }

        private void TriggerButton_Click(object sender, RoutedEventArgs e)
        {
            BindingExpression binding = secondTextBox.GetBindingExpression(TextBox.TextProperty);

            binding.UpdateSource();
        }
    }
}
