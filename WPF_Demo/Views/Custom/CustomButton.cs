using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace WPF_Demo.Views.Custom
{
    public class CustomButton: Button
    {
        public CustomButton()
        {
            Background = new LinearGradientBrush(Colors.White, Colors.Aqua, new Point(0, 0), new Point(1, 1));

            Margin = new Thickness(10);

            Click += (sender, e) =>
            {
                MessageBox.Show("Clicked!");
            };
        }
    }
}
