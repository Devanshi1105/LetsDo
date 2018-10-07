using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace LetsCookApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MyProfileView : ContentPage
    {
        public MyProfileView()
        {
            InitializeComponent();
            NavigationPage.SetHasNavigationBar(this, false);
        }
    }
}
