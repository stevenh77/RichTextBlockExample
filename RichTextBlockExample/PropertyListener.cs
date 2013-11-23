using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;

namespace RichTextBlockExample
{
    public class PropertyListener
    {
        /// <summary>
        /// Listens for changes to dependency properties on a given FrameworkElement calls a callback on property change.
        /// Usage example: PropertyListener.ListenForChange("IsBusy", BusyIndicator, (d,e) => DoStuff())
        /// (may cause memory leaks)
        /// </summary>
        public void ListenForChange(string propertyName, FrameworkElement element, PropertyChangedCallback callback)
        {
            var b = new Binding(propertyName) { Source = element };
            var prop = DependencyProperty.RegisterAttached(
                "ListenAttached" + propertyName,
                typeof(object),
                typeof(Control),
                new PropertyMetadata(callback));
            element.SetBinding(prop, b);
        }
    }
}