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
    /// Interaction logic for ContextMenus.xaml
    /// </summary>
    public partial class ContextMenus : Window
    {
        public ContextMenus()
        {
            InitializeComponent();
        }

        private void Original_Click(object sender, RoutedEventArgs e)
        {
            image.LayoutTransform = new ScaleTransform(1, 1);
        }

        private void FlipVertical_Click(object sender, RoutedEventArgs e)
        {
            image.LayoutTransform = new ScaleTransform(-1, 1);
        }

        private void FlipHorizontal_Click(object sender, RoutedEventArgs e)
        {
            image.LayoutTransform = new ScaleTransform(1, -1);
        }
    }
}
