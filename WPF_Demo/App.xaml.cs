using System;
using System.Windows;

namespace WPF_Demo
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        public App()
        {
            this.Startup += (sender, e) => {
                // MessageBox.Show("The application is starting", "Starting Message");
            };

            this.Exit += (sender, e) => { };

            this.Activated += (sender, e) => { };

            this.Deactivated += (sender, e) => { };

            this.SessionEnding += (sender, e) => { };
        }
    }
}
