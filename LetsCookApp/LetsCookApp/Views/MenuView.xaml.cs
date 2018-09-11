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

        }
    }
}