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

namespace WPF_Demo.Views.Resources
{
    /// <summary>
    /// Interaction logic for DynamicResources.xaml
    /// </summary>
    public partial class DynamicResources : Window
    {
        public DynamicResources()
        {
            InitializeComponent();
        }

        private void LinearButton_Click(object sender, RoutedEventArgs e)
        {
            this.Resources["aqua"] = Brushes.AntiqueWhite;
        }
    }
}
