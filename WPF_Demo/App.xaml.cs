using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
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
            this.Startup += (sender, e) => { MessageBox.Show("The application is starting", "Starting Message"); };

            this.Exit += (sender, e) => { };

            this.Activated += (sender, e) => { };

            this.Deactivated += (sender, e) => { };

            this.SessionEnding += (sender, e) => { };
        }
    }
}
