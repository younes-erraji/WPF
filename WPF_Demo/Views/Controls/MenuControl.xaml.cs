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
    /// Interaction logic for MenuControl.xaml
    /// </summary>
    public partial class MenuControl : Window
    {
        public MenuControl()
        {
            InitializeComponent();


            CommandBinding newBinding = new CommandBinding();
            newBinding.Command = ApplicationCommands.New;
            newBinding.Executed += (sender, e) => {
                MessageBox.Show("New");
            };
            newBinding.CanExecute += (sender, e) => {
                e.CanExecute = true;
            };

            CommandBinding openBinding = new CommandBinding();
            openBinding.Command = ApplicationCommands.Open;
            openBinding.Executed += (sender, e) => {
                MessageBox.Show("Open");
            };
            openBinding.CanExecute += (sender, e) => {
                e.CanExecute = true;
            };

            CommandBindings.Add(newBinding);
            CommandBindings.Add(openBinding);
        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(((MenuItem)sender).Header.ToString(), "Menu Item");
        }
    }
}
