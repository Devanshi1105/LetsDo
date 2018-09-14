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
    public partial class MenuView : ContentPage
    {
        public ListView menuList;
        public MenuView()
        {
            InitializeComponent();
            this.menuList = masterMenuList;
        }

        private void masterMenuList_ItemTapped(object sender, ItemTappedEventArgs e)
        { 
        
            NavigateTo((ViewModels.Menu)e.Item);
        }
        void NavigateTo(ViewModels.Menu menu)
        {
            if (menu.TargetType == typeof(CategoriesView))
            {
                ((MasterDetailPage)App.Current.MainPage).Detail.Navigation.PopToRootAsync();
            }
            else if (menu.TargetType == typeof(SignInView))
            {
                 ((MasterDetailPage)App.Current.MainPage).Detail.Navigation.PushAsync(new SignInView());
            }
            else if (menu.TargetType == typeof(SignUpView))
            {
                ((MasterDetailPage)App.Current.MainPage).Detail.Navigation.PushAsync(new SignUpView());
            }

            else if (menu.TargetType == typeof(Nullable))
            {
                App.Current.MainPage = new NavigationPage(new Views.SignInSignUpView());
            }
            App.AppSetup.HomeViewModel.IsMenuListPresented = false;
        }
    }
}