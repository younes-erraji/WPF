using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace WPF_Demo.Views
{
    /// <summary>
    /// Interaction logic for LinearGradient.xaml
    /// </summary>
    public partial class LinearGradient : Window
    {
        public LinearGradient()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            /*
            LinearGradientBrush brush = new LinearGradientBrush();

            GradientStop firstGradientStop = new GradientStop();
            firstGradientStop.Offset = 0;
            firstGradientStop.Color = Colors.Red;
            brush.GradientStops.Add(firstGradientStop);

            GradientStop secondGradientStop = new GradientStop();
            secondGradientStop.Offset = 0.5;
            secondGradientStop.Color = Colors.Indigo;
            brush.GradientStops.Add(secondGradientStop);

            GradientStop thirdGradientStop = new GradientStop();
            thirdGradientStop.Offset = 1;
            thirdGradientStop.Color = Colors.Violet;
            brush.GradientStops.Add(thirdGradientStop);

            MainGrid.Background = brush;
            */

            ButtonSubmit.Foreground = SystemColors.ActiveCaptionBrush;
        }

        private void ButtonSubmit_Click(object sender, RoutedEventArgs e)
        {
            this.Cursor = Cursors.Wait;
            MessageBox.Show($"The Grid Is [{MainGrid.ActualWidth}X{MainGrid.ActualHeight}]");
        }
    }
}
