using System;
using System.Windows.Markup;

namespace WPF_Demo.Views.MarkupExtensions
{
    class ShowTime: MarkupExtension
    {
        public string Header { get; set; }

        public ShowTime() { }

        public ShowTime(string Header)
        {
            this.Header = Header;
        }

        public override object ProvideValue(IServiceProvider serviceProvider)
        {
            return string.Format($"{Header}: {DateTime.Now.ToLongTimeString()}");
        }
    }
}
