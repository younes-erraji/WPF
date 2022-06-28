using System;
using System.Windows;

namespace WPF_Demo.Views.Layouts
{
    /// <summary>
    /// Interaction logic for Layouts.xaml
    /// </summary>
    public partial class Layouts : Window
    {
        public Layouts()
        {
            InitializeComponent();
        }

        private void Check_First_Panel_Checked(object sender, RoutedEventArgs e)
        {
            uniformGridSection.Visibility = Visibility.Collapsed;
        }

        private void Check_First_Panel_Unchecked(object sender, RoutedEventArgs e)
        {
            uniformGridSection.Visibility = Visibility.Visible;
        }

        private void Check_Second_Panel_Checked(object sender, RoutedEventArgs e)
        {
            tabControlSection.Visibility = Visibility.Collapsed;
        }

        private void Check_Second_Panel_Unchecked(object sender, RoutedEventArgs e)
        {
            tabControlSection.Visibility = Visibility.Visible;
        }

        private void Check_Third_Panel_Checked(object sender, RoutedEventArgs e)
        {
            redFrame.Visibility = Visibility.Collapsed;
        }

        private void Check_Third_Panel_Unchecked(object sender, RoutedEventArgs e)
        {
            redFrame.Visibility = Visibility.Visible;
        }

        private void Check_Fourth_Panel_Checked(object sender, RoutedEventArgs e)
        {
            blueFrame.Visibility = Visibility.Hidden;
        }

        private void Check_Fourth_Panel_Unchecked(object sender, RoutedEventArgs e)
        {
            blueFrame.Visibility = Visibility.Visible;
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            
        }
    }
}
