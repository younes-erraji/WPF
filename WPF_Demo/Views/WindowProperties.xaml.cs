using System;
using System.Windows;
using System.Threading;

namespace WPF_Demo.Views
{
    /// <summary>
    /// Interaction logic for WindowProperties.xaml
    /// </summary>
    public partial class WindowProperties : Window
    {
        public WindowProperties()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Window window = new Window {
                Title = "Created Window!",
                Height = 400,
                Width = 400,
                Topmost = true,
                ShowInTaskbar = false,
                WindowStartupLocation = WindowStartupLocation.CenterOwner,
                VerticalContentAlignment = VerticalAlignment.Center,
                HorizontalContentAlignment = HorizontalAlignment.Center,
                Content = "Created Window!",
                
            };

            // window.ShowDialog();
            // window.Show();

            bool? result = window.ShowDialog();

            MessageBox.Show(result.ToString());

            // this.Hide();
        }

        private void Close_Click(object sender, EventArgs e)
        {
            
        }

        private void MessageBox_Click(object sender, EventArgs e)
        {
            MessageBoxResult result = MessageBox.Show("Lorem Ipsum Dolor", "Lorem Ipsum!", MessageBoxButton.OKCancel, MessageBoxImage.Error, MessageBoxResult.OK, MessageBoxOptions.DefaultDesktopOnly);

            if (result == MessageBoxResult.OK)
            {

            }
        }
    }
}
