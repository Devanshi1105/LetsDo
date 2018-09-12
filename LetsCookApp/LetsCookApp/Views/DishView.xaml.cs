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
	public partial class DishView : ContentPage
	{
		public DishView ()
        {
            InitializeComponent();
            NavigationPage.SetHasNavigationBar(this, false);

            lst1.ItemsSource = new List<Contacts>()
            {
    new Contacts() {
            Name = "Umair Here, you can see that we", Num = "0456445450945", imgsource = "nact.png",
        },
        new Contacts() {
            Name = "Cat Here, you can see that we", Num = "034456445905", imgsource = "nact.png",
        },
        new Contacts() {
            Name = "Nature Here, you can see that we", Num = "56445905", imgsource = "act.png",
        },
        new Contacts() {
            Name = "Nature Here, you can see that we", Num = "56445905", imgsource = "nact.png",
        },
};


            lst2.ItemsSource = new List<Contacts>()
            {
    new Contacts() {
            Name = "Umair Here, you can see that we used the ImageCell and set Binding. We set Binding of ‘Text’ with ‘Name’, ", Num = "0456445450945", imgsource = "you_tab",
        },
        new Contacts() {
            Name = "Cat Here, you can see that we used the ImageCell and set Binding. We set Binding of ‘Text’ with ‘Name’, ", Num = "034456445905", imgsource = "nact.png",
        },
        new Contacts() {
            Name = "Nature Here, you can see that we used the ImageCell and set Binding. We set Binding of ‘Text’ with ‘Name’, ", Num = "56445905", imgsource = "nact.png",
        },
         new Contacts() {
            Name = "Nature Here, you can see that we used the ImageCell and set Binding. We set Binding of ‘Text’ with ‘Name’, ", Num = "56445905", imgsource = "act.png",
        },
                new Contacts() {
            Name = "Cat Here, you can see that we used the ImageCell and set Binding. We set Binding of ‘Text’ with ‘Name’, ", Num = "034456445905", imgsource = "you_tab",
        },
        new Contacts() {
            Name = "Nature Here, you can see that we used the ImageCell and set Binding. We set Binding of ‘Text’ with ‘Name’, ", Num = "56445905", imgsource = "act.png",
        },
                new Contacts()
                {
                    Name = "Cat Here, you can see that we used the ImageCell and set Binding. We set Binding of ‘Text’ with ‘Name’, ", Num = "034456445905", imgsource = "nact.png",
                },
        new Contacts()
        {
            Name = "Nature Here, you can see that we used the ImageCell and set Binding. We set Binding of ‘Text’ with ‘Name’, ", Num = "56445905", imgsource = "act.png",
        },
            };
        }

        private void lst2_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            var item = e.Item as Contacts;
            if (item.imgsource == "nact")
            {
                item.imgsource = "act";
            }
            else
            {
                item.imgsource = "nact";
            }
        }
        private void lst1_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            var item = e.Item as Contacts;
            if (item.imgsource == "nact")
            {
                item.imgsource = "act";
            }
            else
            {
                item.imgsource = "nact";
            }
        }
    }

    public class Contacts
    {
        public string Name
        {
            get;
            set;
        }
        public string Num
        {
            get;
            set;
        }
        public string imgsource
        {
            get;
            set;
        }
    }
}
