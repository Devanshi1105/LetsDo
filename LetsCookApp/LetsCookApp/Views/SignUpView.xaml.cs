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
    public partial class SignUpView : ContentPage
    {
        public SignUpView()
        {
            InitializeComponent();
            NavigationPage.SetHasNavigationBar(this, false);
        }

        private void Create_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new CategoriesView());
        }
        private void SignIn_Tapped(object sender, EventArgs e)
        {
            Navigation.PushAsync(new SignInView());
        }
    }
}