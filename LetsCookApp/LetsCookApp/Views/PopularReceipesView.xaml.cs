﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace LetsCookApp.Views
{
    public partial class PopularReceipesView : ContentPage
    {
        public PopularReceipesView()
        {
            InitializeComponent();
            List<SubCategory> _listAvailableAward = new List<SubCategory>()
            {
                new SubCategory {foodIcon = "Chutney.png" ,  UserRating=2, DishName = "Coconut Chutney", likeIcon = "icon.png" ,timeIcon = "icon.png" ,Time = "9 MIn", servingIcon = "icon.png", Servings="6 Servings",ingrendIcon="icon.png" , Ingrendients="14 Ingredients" ,plusIcon="icon.png"},
                 new SubCategory {foodIcon = "Paneer.png" , UserRating=2,DishName = "Kadai Paneer", likeIcon = "icon.png" ,timeIcon = "icon.png" ,Time = "30 MIn", servingIcon = "icon.png", Servings="4 Servings",ingrendIcon="icon.png" , Ingrendients="8 Ingredients" ,plusIcon="icon.png"},
                new SubCategory {foodIcon = "Snacks.png" , UserRating=2,DishName = "Bread Katori Chaat", likeIcon = "icon.png" ,timeIcon = "icon.png" ,Time = "15 MIn", servingIcon = "icon.png", Servings="4 Servings",ingrendIcon="icon.png" , Ingrendients="7 Ingredients" ,plusIcon="icon.png"},
        };

            //RaisePropertyChanged(() => ListAvailableAward);

           
            listSubCatgory.ItemsSource = _listAvailableAward;

            NavigationPage.SetHasNavigationBar(this, false);
        }
        private void Menu_Tapped(object sender, EventArgs e)
        {
            App.AppSetup.HomeViewModel.IsMenuListPresented = true;
        }
    }
}
