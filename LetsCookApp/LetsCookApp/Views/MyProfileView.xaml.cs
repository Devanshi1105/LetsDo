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

        
        private void Timeline_Tapped(object sender, EventArgs e)
        {
            TLine.IsVisible =grdTimeline.IsVisible= true;
            ALine.IsVisible = FLine.IsVisible = GLine.IsVisible = false;
            grdAboutme.IsVisible = grdFriends.IsVisible = grdGallery.IsVisible = false;
        }
        private void AboutMe_Tapped(object sender, EventArgs e)
        {
            ALine.IsVisible =grdAboutme.IsVisible= true;
            TLine.IsVisible = FLine.IsVisible = GLine.IsVisible = false;
            grdTimeline.IsVisible = grdFriends.IsVisible = grdGallery.IsVisible = false;

        }
        private void Friends_Tapped(object sender, EventArgs e)
        {
            FLine.IsVisible = grdFriends.IsVisible= true;
            TLine.IsVisible = ALine.IsVisible = GLine.IsVisible = false;
            grdTimeline.IsVisible = grdFriends.IsVisible = grdGallery.IsVisible = false;
        }
        private void Gallery_Tapped(object sender, EventArgs e)
        {
            GLine.IsVisible =grdGallery.IsVisible= true;
            TLine.IsVisible = FLine.IsVisible = ALine.IsVisible = false;
            grdTimeline.IsVisible = grdFriends.IsVisible = grdAboutme.IsVisible = false;
        }
    }


}
