using System;
using System.Threading;
using System.Threading.Tasks;

using System.Windows;

namespace WPF_Demo.Views.Threading
{
    /// <summary>
    /// Interaction logic for ThreadingWindow.xaml
    /// </summary>
    public partial class ThreadingWindow : Window
    {
        public ThreadingWindow() {
            InitializeComponent();
        }

        private async void Button_Click(object sender, RoutedEventArgs e) {
            for (int i = 1; i <= 100; i++) {
                var value_thread = await GetProgressValue(i);
                DownloadProgress.Value = value_thread.value;
                LThreading.Content = $"The Secondary Thread: {value_thread.thread}";
            }
        }

        Task<(int value, int thread)> GetProgressValue(int i) {
            return Task.Run(() => {
                Thread.Sleep(100);
                return (value: i, thread: Thread.CurrentThread.ManagedThreadId);
            });
        }
    }
}
