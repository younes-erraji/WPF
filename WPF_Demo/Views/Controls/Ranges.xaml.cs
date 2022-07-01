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
    /// Interaction logic for Ranges.xaml
    /// </summary>
    public partial class Ranges : Window
    {
        public Ranges()
        {
            InitializeComponent();
        }

        private void NextStepButton_Click(object sender, RoutedEventArgs e)
        {
            progress.Value += 5;
            VProgress.Value += 5;
        }
    }
}
