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
                new Menu {Title = "Tessera Thinkard", Icon = "card.png", TargetType = typeof(SearchView)},
                new Menu {Title = "Movimenti", Icon = "movement.png", TargetType = typeof(CategoriesView)},
                new Menu {Title = "Punti Vendita", Icon = "store.png", TargetType = typeof(SearchView)},
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
        public ImageSource Icon { get; set; }
        public Type TargetType { get; set; }
    }
}
