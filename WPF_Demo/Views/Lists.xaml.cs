using System;
using System.Windows;
using System.Windows.Controls;

namespace WPF_Demo.Views
{
    /// <summary>
    /// Interaction logic for Lists.xaml
    /// </summary>
    public partial class Lists : Window
    {
        public Lists()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            object obj = ListNames.SelectedItem;
            string selected = (obj == null) ? "No Item Seleceted!" : ((ListBoxItem)obj).Content.ToString();

            MessageBox.Show(selected, "Selected Item");
        }

        private void ListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ListBox list = sender as ListBox;
            ListBoxItem listItem = list.SelectedItem as ListBoxItem;

            MessageBox.Show(listItem.Content.ToString(), "Selected");
        }

        private void MultipleSelectButton_Click(object sender, RoutedEventArgs e)
        {
            foreach (ListBoxItem item in MultipleNamesList.Items)
            {
                if (item.IsSelected)
                    MessageBox.Show(item.Content.ToString());
            }
        }

        private void GetNameFromComboBox_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(firtComboBox.SelectionBoxItem.ToString(), "Selecetd");
        }
    }
}
