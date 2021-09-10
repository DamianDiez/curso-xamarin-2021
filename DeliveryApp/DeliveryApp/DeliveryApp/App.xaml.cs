using DeliveryApp.Models;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace DeliveryApp
{
    public partial class App : Application
    {
        public static User CurrentUser;

        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new Views.SignUpStep1View());
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
