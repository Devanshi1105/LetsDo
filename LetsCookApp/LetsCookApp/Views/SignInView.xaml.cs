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
    public partial class SignInView : ContentPage
    {
        public SignInView()
        {
            InitializeComponent();
            NavigationPage.SetHasNavigationBar(this, false);
        }

        private void CreateAccount_Tapped(object sender, EventArgs e)
        {
             Navigation.PushAsync(new SignUpView());
        }
        private void SignIn_Clicked(object sender, EventArgs e)
        {
             App.Current.MainPage = new Views.HomeView();
          
        }

        
    }
}