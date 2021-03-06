﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace LetsCookApp.Views
{
    public partial class MyFavouritesRecipesView : ContentPage
    {
        public MyFavouritesRecipesView()
        {
            List<SubCategory> _listAvailableAward = new List<SubCategory>()
            {
                new SubCategory {foodIcon = "NoOnion.png" ,DishName = "Paneer Butter Masala", likeIcon = "icon.png" ,timeIcon = "icon.png" ,Time = "9 MIn", servingIcon = "icon.png", Servings="6 Servings",ingrendIcon="icon.png" , Ingrendients="14 Ingredients" ,plusIcon="icon.png"},
                new SubCategory {foodIcon = "Breakfast.png" ,DishName = "Rava Utappa", likeIcon = "icon.png" ,timeIcon = "icon.png" ,Time = "30 MIn", servingIcon = "icon.png", Servings="4 Servings",ingrendIcon="icon.png" , Ingrendients="8 Ingredients" ,plusIcon="icon.png"},
                new SubCategory {foodIcon = "Diabetic.png" ,DishName = "Oats For Diabetics", likeIcon = "icon.png" ,timeIcon = "icon.png" ,Time = "15 MIn", servingIcon = "icon.png", Servings="4 Servings",ingrendIcon="icon.png" , Ingrendients="7 Ingredients" ,plusIcon="icon.png"},
            };

            //RaisePropertyChanged(() => ListAvailableAward);

            InitializeComponent();
            listSubCatgory.ItemsSource = _listAvailableAward;

            NavigationPage.SetHasNavigationBar(this, false);
        }
        private void Menu_Tapped(object sender, EventArgs e)
        {
            App.AppSetup.HomeViewModel.IsMenuListPresented = true;
        }
        private void Search_Tapped(object sender, EventArgs e)
        {
            var page = new SearchView();

            Rg.Plugins.Popup.Services.PopupNavigation.PushAsync(page);
        }
    }
}
