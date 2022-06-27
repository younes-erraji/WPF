using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Markup;

namespace WPF_Demo.ClassesViews
{
    public class ClassWindow : Window
    {
        public Button submitButton { get; set; }
        public ClassWindow()
        {
            InitializeComponent();
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
