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

namespace WPF_Demo.Views.Bindings
{
    /// <summary>
    /// Interaction logic for DeleteBindings.xaml
    /// </summary>
    public partial class DeleteBindings : Window
    {
        public DeleteBindings()
        {
            InitializeComponent();
        }

        private void ClearFont_Click(object sender, RoutedEventArgs e)
        {
            BindingOperations.ClearBinding(displayText, FontFamilyProperty);
        }

        private void ClearWeight_Click(object sender, RoutedEventArgs e)
        {
            BindingOperations.ClearBinding(displayText, FontWeightProperty);
        }

        private void ClearAll_Click(object sender, RoutedEventArgs e)
        {
            BindingOperations.ClearAllBindings(displayText);
        }

        private void CreateBindings_Click(object sender, RoutedEventArgs e)
        {
            Binding fontBinding = new Binding
            {
                Source = fontBox,
                Path = new PropertyPath("Text"),
                Mode = BindingMode.OneWay
            };

            displayText.SetBinding(FontFamilyProperty, fontBinding);

            Binding weightBinding = new Binding
            {
                Source = weightBox,
                Path = new PropertyPath("Text"),
                Mode = BindingMode.OneWay
            };

            displayText.SetBinding(FontWeightProperty, weightBinding);
        }
    }
}
