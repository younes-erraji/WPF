using System;

using System.Windows;
using System.Windows.Media;

namespace WPF_Demo.Views.Resources
{
    /// <summary>
    /// Interaction logic for ResourcesWindow.xaml
    /// </summary>
    public partial class ResourcesWindow : Window
    {
        public ResourcesWindow()
        {
            InitializeComponent();

            container.Resources.Add("background", Brushes.Silver);
            container.Resources.Add("whiteColor", Brushes.White);

            // FirstButton.Background = (Brush)FirstButton.FindResource("background");
            // FirstButton.Foreground = (Brush)FirstButton.FindResource("whiteColor");

            // FirstButton.Background = (Brush)FirstButton.TryFindResource("background");
            // FirstButton.Foreground = (Brush)FirstButton.TryFindResource("whiteColor");

            // FirstButton.Background = (Brush)container.Resources["background"];
            // FirstButton.Foreground = (Brush)container.Resources["whiteColor"];
        }

        private void FirstButton_Click(object sender, RoutedEventArgs e)
        {
            App app = (App)Application.Current;
            app.Shutdown();
        }
    }
}
