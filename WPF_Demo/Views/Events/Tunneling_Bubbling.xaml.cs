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

namespace WPF_Demo.Views.Events
{
    /// <summary>
    /// Interaction logic for Tunneling_Bubbling.xaml
    /// </summary>
    public partial class Tunneling_Bubbling : Window
    {
        public Tunneling_Bubbling()
        {
            InitializeComponent();
        }

        private void MBorder_MouseUp(object sender, MouseButtonEventArgs e)
        {
            events.Text += "Bubbling: Border\n";
        }

        private void MBorder_PreviewMouseUp(object sender, MouseButtonEventArgs e)
        {
            events.Text += "Tunneling: Border\n";
        }

        private void MLabel_MouseUp(object sender, MouseButtonEventArgs e)
        {
            events.Text += "Bubbling: Label\n";
        }

        private void MLabel_PreviewMouseUp(object sender, MouseButtonEventArgs e)
        {
            events.Text += "Tunneling: Label\n";
        }

        private void MButton_MouseUp(object sender, MouseButtonEventArgs e)
        {
            events.Text += "Bubbling: Button\n";
        }

        private void MButton_PreviewMouseUp(object sender, MouseButtonEventArgs e)
        {
            events.Text += "Tunneling: Button\n";
        }

        private void ClearButton_Click(object sender, RoutedEventArgs e)
        {
            events.Text = "";
        }
    }
}
