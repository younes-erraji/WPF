using System;

using System.Windows.Input;

namespace WPF_Demo.Views.Commands.Custom
{
    class ReverseCommand
    {
        static RoutedUICommand reverse;
        public static RoutedUICommand Reverse { get { return reverse; } }

        static ReverseCommand()
        {
            InputGestureCollection gesture = new InputGestureCollection();

            gesture.Add(new KeyGesture(Key.R, ModifierKeys.Control, "Control-R"));

            reverse = new RoutedUICommand("Reverse", "Reverse", typeof(ReverseCommand), gesture);
        }
    }
}
