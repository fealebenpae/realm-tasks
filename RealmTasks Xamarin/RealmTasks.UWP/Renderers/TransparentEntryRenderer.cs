using RealmTasks;
using RealmTasks.UWP;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml.Media;
using Xamarin.Forms;
using Xamarin.Forms.Platform.UWP;

[assembly: ExportRenderer(typeof(TransparentEntry), typeof(TransparentEntryRenderer))]
namespace RealmTasks.UWP
{
    public class TransparentEntryRenderer : EntryRenderer
    {
        protected override void OnElementChanged(ElementChangedEventArgs<Entry> e)
        {
            base.OnElementChanged(e);

            if (Control != null)
            {
                Control.BorderThickness = new Windows.UI.Xaml.Thickness(0);
                Control.Background = new SolidColorBrush(Windows.UI.Colors.Transparent);
                Control.BackgroundFocusBrush = new SolidColorBrush(Windows.UI.Color.FromArgb(30, 255, 255, 255));
                Control.Padding = new Windows.UI.Xaml.Thickness(15, 15, 0, 0);

                UpdateStrikeThrough(e.NewElement as TransparentEntry);
            }
        }

        protected override void OnElementPropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            base.OnElementPropertyChanged(sender, e);

            if (e.PropertyName == nameof(TransparentEntry.IsStrikeThrough))
            {
                UpdateStrikeThrough(sender as TransparentEntry);
            }
        }

        private void UpdateStrikeThrough(TransparentEntry entry)
        {
            // strikethrough effect not supported yet
        }
    }
}
