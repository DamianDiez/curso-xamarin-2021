using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Demo01_Paginas
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new Paginas.PaginaLogin();
                //new NavigationPage(new Paginas.PaginaLogin());
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
