using System;
using System.Reflection;
using System.Collections.Generic;

using System.Windows;
using System.Windows.Data;

using WPF_Demo.Models;

namespace WPF_Demo.Views.Bindings
{
    /// <summary>
    /// Interaction logic for Bindings_ItemsControls.xaml
    /// </summary>
    public partial class Bindings_ItemsControls : Window
    {
        public Bindings_ItemsControls()
        {
            InitializeComponent();

            Person[] people =
            {
                new Person(2, "AB852913", "Issam", "Housni", 22),
                new Person(3, "AB852913", "Oumaima", "Qorsi", 21),
                new Person(4, "AB852913", "Mustapha", "Salih", null),
                new Person(5, "AB852913", "Safae", "ERRAJI", null),
            };

            comboPeople.ItemsSource = people;

            Type type = typeof(Person);
            Dictionary<string, Binding> dictionary = new Dictionary<string, Binding>();
            foreach (PropertyInfo property in type.GetProperties())
            {
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
