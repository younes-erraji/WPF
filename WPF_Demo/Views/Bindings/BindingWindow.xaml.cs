using System;
using System.Windows;
using System.Windows.Data;
using System.Windows.Controls;

namespace WPF_Demo.Views.Bindings
{
    /// <summary>
    /// Interaction logic for BindingWindow.xaml
    /// </summary>
    public partial class BindingWindow : Window
    {
        public BindingWindow()
        {
            InitializeComponent();

            Binding binding = new Binding
            {
                Source = sourceText,
                Path = new PropertyPath("Text")
            };

            displayText.SetBinding(Label.ContentProperty, binding);
        }
    }
}
