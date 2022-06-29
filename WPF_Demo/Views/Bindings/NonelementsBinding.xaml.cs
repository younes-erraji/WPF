using System;
using System.Collections.Generic;
using System.Reflection;

using System.Windows;
using System.Windows.Data;

using WPF_Demo.Models;

namespace WPF_Demo.Views.Bindings
{
    /// <summary>
    /// Interaction logic for NonelementsBinding.xaml
    /// </summary>
    public partial class NonelementsBinding : Window
    {
        public NonelementsBinding()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            Person person = new Person {
                ID = 1,
                Identity = "AD197364",
                FirstName = "Younes",
                LastName = "ERRAJI",
                Age = 21
            };

            // Without Data Context
            /*
            {
                Type type = typeof(Person);
                Dictionary<string, Binding> dictionary = new Dictionary<string, Binding>();
                foreach (PropertyInfo property in type.GetProperties()) {
                    dictionary.Add(property.Name, new Binding(property.Name) {
                        Source = person,
                    });
                }

                LID.SetBinding(ContentProperty, dictionary["ID"]);
                LIdentity.SetBinding(ContentProperty, dictionary["Identity"]);
                LFirstName.SetBinding(ContentProperty, dictionary["FirstName"]);
                LLastName.SetBinding(ContentProperty, dictionary["LastName"]);
                LAge.SetBinding(ContentProperty, dictionary["Age"]);
            }
            */

            // With Data Context
            {
                gridContainer.DataContext = person;
                Type type = typeof(Person);
                Dictionary<string, Binding> dictionary = new Dictionary<string, Binding>();
                foreach (PropertyInfo property in type.GetProperties()) {
                    dictionary.Add(property.Name, new Binding(property.Name));
                }

                LID.SetBinding(ContentProperty, dictionary["ID"]);
                LIdentity.SetBinding(ContentProperty, dictionary["Identity"]);
                LFirstName.SetBinding(ContentProperty, dictionary["FirstName"]);
                LLastName.SetBinding(ContentProperty, dictionary["LastName"]);
                LAge.SetBinding(ContentProperty, dictionary["Age"]);
            }
        }
    }
}
