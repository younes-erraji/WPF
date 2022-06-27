using System;
using System.Windows;
using System.Threading;

namespace WPF_Demo.Views.Layouts
{
    /// <summary>
    /// Interaction logic for Canvas.xaml
    /// </summary>
    public partial class CanvasLayout : Window
    {
        public CanvasLayout()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            // Thread.Sleep(10000);
            // MessageBox.Show("Hello World!");
        }
    }
}
