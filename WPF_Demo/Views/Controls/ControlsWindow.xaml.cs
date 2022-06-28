using System;
using System.Windows;
using System.Windows.Media.Imaging;

namespace WPF_Demo.Views.Controls
{
    /// <summary>
    /// Interaction logic for ControlsWindow.xaml
    /// </summary>
    public partial class ControlsWindow : Window
    {
        public ControlsWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            // LabelNumber.Content = ComboBoxNumbers.SelectedItem.ToString();
            LabelNumber.Content = ComboBoxNumbers.SelectionBoxItem.ToString();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            Uri uri = new Uri("../../Assets/Images/Photoshop.PNG", UriKind.Relative);
            BitmapImage bitmap = new BitmapImage(uri);
            Logo.Source = bitmap;
        }
    }
}
