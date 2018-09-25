//using LetsCookApp.Views;
using LetsCookApp.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace LetsCookApp.ViewModels
{
    public class HomeViewModel : BaseViewModel
    {
        public HomeViewModel()
        {
            IsMenuListPresented = false;
            _menuItemList = new List<Menu>()
            {
                  new Menu {Title = "My Profile",  TargetType = typeof(CategoriesView)},
                    new Menu {Title = "Newly Added Recipes",  TargetType = typeof(CategoriesView)},
                      new Menu {Title = "Categories",  TargetType = typeof(CategoriesView)},
                        new Menu {Title = "My Favourites Recipes",  TargetType = typeof(CategoriesView)},
                          new Menu {Title = "Shopping List",  TargetType = typeof(ShoppingListView)},
                new Menu {Title = "Suggest Recipes",  TargetType = typeof(CategoriesView)},
                new Menu {Title = "Please Help Me", TargetType = typeof(ShoppingListView)},
                new Menu {Title = "About the App", TargetType = typeof(SearchView)},
                new Menu {Title = "Settings",  TargetType = typeof(SearchView)},
                new Menu {Title = "ShareApp",  TargetType = typeof(SearchView)},
            };
            RaisePropertyChanged(() => MenuItemList);
        }

        #region Set Properties

        private bool _isMenuListPresented;
        public bool IsMenuListPresented
        {
            get { return _isMenuListPresented; }
            set
            {
                _isMenuListPresented = value;
                RaisePropertyChanged(() => IsMenuListPresented);
            }
        }

        private List<Menu> _menuItemList;
        public List<Menu> MenuItemList
        {
            get { return _menuItemList; }
            set
            {
                _menuItemList = value;
                RaisePropertyChanged(() => MenuItemList);
            }
        }

        #endregion
    }

    public class Menu
    {
        public string Title { get; set; }     
        public Type TargetType { get; set; }
    }
}
