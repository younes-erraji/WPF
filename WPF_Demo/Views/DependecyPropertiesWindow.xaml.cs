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

namespace WPF_Demo.Views
{
    /// <summary>
    /// Interaction logic for DependecyPropertiesWindow.xaml
    /// </summary>
    public partial class DependecyPropertiesWindow : Window
    {
        public DependecyPropertiesWindow()
        {
            InitializeComponent();

            // FrameworkPropertyMetadata metadata = new FrameworkPropertyMetadata(0, new PropertyChangedCallback(Grid.OnCellAttachedPropertyChanged));

            // Grid.RowProperty = DependencyProperty.Register("Row", typeof(int), typeof(Grid), metadata, new ValidateValueCallback(Grid.IsIntValueNotNegative));

            SetBackgroundColor();
            SetChildren();
        }

        public Color SetColor(byte R, byte G, byte B, byte A)
        {
            Color color = new Color();
            color.R = R;
            color.G = G;
            color.B = B;
            color.A = A;
            
            return color;
        }

        public void SetBackgroundColor()
        {
            // this.Background = new SolidColorBrush(SetColor(1, 200, 154, 25));

            Point startPoint = new Point(0, 0);
            Point endPoint = new Point(1, 1);

            this.Background = new LinearGradientBrush(Colors.White, Colors.Blue, startPoint, endPoint);

            // this.Background = new RadialGradientBrush(Colors.White, Colors.Aqua);
        }

        public void SetChildren()
        {
            Grid grid = new Grid();
            grid.RowDefinitions.Add(new RowDefinition());
            grid.RowDefinitions.Add(new RowDefinition { Height = GridLength.Auto });
            grid.RowDefinitions.Add(new RowDefinition());

            TextBox box = new TextBox();
            box.Text = "Placeholder...";

            Button button = new Button();
            button.Content = "Submit";

            Grid.SetRow(box, 0);
            Grid.SetColumn(box, 0);

            Grid.SetRow(button, 1);
            Grid.SetColumn(button, 0);

            grid.Children.Add(box);
            grid.Children.Add(button);

            Content = grid;
        }
    }
}
