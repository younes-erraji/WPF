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

namespace WPF_Demo.Views.DependencyProperties
{
    /// <summary>
    /// Interaction logic for AttachedProperties.xaml
    /// </summary>
    public partial class AttachedProperties : Window
    {
        public static readonly DependencyProperty CountProperty;

        static AttachedProperties()
        {
            CountProperty = DependencyProperty.RegisterAttached("Count", typeof(int), typeof(AttachedProperties));
        }

        public AttachedProperties()
        {
            InitializeComponent();

            IntStorage firstStorage = new IntStorage();
            IntStorage secondStorage = new IntStorage();

            SetCount(firstStorage, 48);
            SetCount(secondStorage, 107);

            int first = GetCount(firstStorage);
            int second = GetCount(secondStorage);

            firstTxt.Text = first.ToString();
            secondTxt.Text = second.ToString();
        }

        public static int GetCount(IntStorage ints)
        {
            return (int)ints.GetValue(CountProperty);
        }

        public static void SetCount(IntStorage ints, int value)
        {
            ints.SetValue(CountProperty, value);
        }
    }

    public class IntStorage: DependencyObject
    {

    }
}
