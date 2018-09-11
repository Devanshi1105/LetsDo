using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace LetsCookApp.CustomViews
{
    public class CustomPicker : Picker
    {

        public static readonly BindableProperty FontSizeProperty =
            BindableProperty.Create<CustomPicker, double>(p => p.FontSize, Font.Default.FontSize);
        public double FontSize
        {
            get { return (double)GetValue(FontSizeProperty); }
            set { SetValue(FontSizeProperty, value); }
        }

        public static readonly BindableProperty IsCompletedProperty =
            BindableProperty.Create<CustomPicker, bool>(p => p.IsCompleted, false);
        public bool IsCompleted
        {
            get { return (bool)GetValue(IsCompletedProperty); }
            set { SetValue(IsCompletedProperty, value); }
        }

    }
}
