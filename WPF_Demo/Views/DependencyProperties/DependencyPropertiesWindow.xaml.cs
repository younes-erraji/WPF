using System;
using System.Windows;
using System.Windows.Media;
using System.Windows.Controls;
using System.Diagnostics;

namespace WPF_Demo.Views.DependencyProperties
{
    /// <summary>
    /// Interaction logic for DependecyPropertiesWindow.xaml
    /// </summary>
    public partial class DependencyPropertiesWindow : Window
    {
        public static readonly DependencyProperty SidesProperty;

        public int Sides {
            get { return (int)GetValue(SidesProperty); }
            set { SetValue(SidesProperty, value); }
        }

        static DependencyPropertiesWindow()
        {
            FrameworkPropertyMetadata metadata = new FrameworkPropertyMetadata();
            metadata.AffectsArrange = true;
            metadata.Inherits = true;
            metadata.PropertyChangedCallback = (dependencyObject, eventArgs) =>
            {
                DependencyPropertiesWindow window = dependencyObject as DependencyPropertiesWindow;

                if (window == null || window.poly == null)
                {
                    return;
                }
                else
                {
                    const int xCenter = 65, yCenter = 50, radius = 85;

                    double rads = Math.PI / window.Sides * 2;

                    window.poly.Points.Clear();
                    window.poly.Points.Add(new Point(xCenter + radius, yCenter));

                    for (double i = 1; i <= window.Sides - 1; i++)
                    {
                        double x = (Math.Cos(rads * i) * radius) + xCenter,
                            y = (Math.Sin(rads * i) * radius) + yCenter;

                        window.poly.Points.Add(new Point(x, y));
                    }
                }
            };

            SidesProperty = DependencyProperty.Register("Sides", typeof(int), typeof(DependencyPropertiesWindow), metadata);
        }

        public DependencyPropertiesWindow()
        {
            InitializeComponent();

            // SetBackgroundColor();
            // SetChildren();
        }

        private void Input_TextChanged(object sender, TextChangedEventArgs e)
        {
            int sideCount;
            bool success = int.TryParse(Input.Text, out sideCount);
            if (success && sideCount > 2)
                Sides = sideCount;
        }

        /*
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
        */
    }
}
