using System;
using System.IO;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Markup;

namespace WPF_Demo.ClassesViews
{
    class LoadXaml: Window
    {
        public Button submitButton { get; set; }

        public LoadXaml()
        {
            InitializeComponent();
        }

        public LoadXaml(string XamlFile)
        {
            this.Width = this.Height = 300;
            this.Left = this.Top = 100;
            this.Title = "Dynamically  Loaded XAML";

            DependencyObject rootElement;
            using (FileStream file = new FileStream(XamlFile, FileMode.Open))
            {
                rootElement = (DependencyObject)XamlReader.Load(file);
            }

            this.Content = rootElement;

            {
                submitButton = (Button)LogicalTreeHelper.FindLogicalNode(rootElement, "ButtonSubmit");
                // Or
                // FrameworkElement frameworkElement = (FrameworkElement)rootElement;
                // submitButton = (Button)frameworkElement.FindName("ButtonSubmit");
            }

            submitButton.Click += (sender, e) =>
            {
                submitButton.Content = "Clicked!";
            };
        }

        private void InitializeComponent()
        {
            this.Width = this.Height = 300;
            this.Left = this.Top = 100;
            this.Title = "Code-Only Window";

            DockPanel panel = new DockPanel();

            submitButton = new Button();
            submitButton.Content = "Click Me!";
            submitButton.Margin = new Thickness(20);

            submitButton.Click += (sender, e) =>
            {
                submitButton.Content = "Clicked!";
            };

            IAddChild container = panel;
            container.AddChild(submitButton);

            container = this;
            container.AddChild(panel);
        }
    }
}
