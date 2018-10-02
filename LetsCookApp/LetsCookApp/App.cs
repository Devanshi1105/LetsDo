using GalaSoft.MvvmLight.Ioc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xamarin.Forms;
using CommonServiceLocator;
using LetsCookApp.Views;

namespace LetsCookApp
{
    public class App : Application
    {
        public static AppSetup AppSetup { get { return appSetup; } }
        private static AppSetup appSetup;
        public App()
        {
            ServiceLocator.SetLocatorProvider(() => SimpleIoc.Default);
            SimpleIoc.Default.Register<AppSetup>();
            appSetup = ServiceLocator.Current.GetInstance<AppSetup>();

            // The root page of your application
            var content = new ContentPage
            {
                Title = "LetsCookApp",
                Content = new StackLayout
                {
                    VerticalOptions = LayoutOptions.Center,
                    Children = {
                        new Label {
                            HorizontalTextAlignment = TextAlignment.Center,
                            Text = "Welcome to Xamarin Forms!"
                        }
                    }
                }
            };

           // appSetup.LoginViewModel.GetAllCategory();
            MainPage = new NavigationPage(new SignInSignUpView());
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
