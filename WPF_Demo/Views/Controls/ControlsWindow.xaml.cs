using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

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
