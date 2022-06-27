using System;
using System.Windows;

using WPF_Demo.ClassesViews;

namespace WPF_Demo.Views
{
    /// <summary>
    /// Interaction logic for CodeWindow.xaml
    /// </summary>
    public partial class CodeWindow : Window
    {
        public CodeWindow()
        {
            InitializeComponent();

            /*
            ClassWindow window = new ClassWindow();
            window.Show();
            */

            this.Close();
        }
    }
}
