﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace LetsCookApp.Views
{
    public partial class ShareAppView : ContentPage
    {
        public ShareAppView()
        {
            InitializeComponent();
            NavigationPage.SetHasNavigationBar(this, false);
        }
    }
}
