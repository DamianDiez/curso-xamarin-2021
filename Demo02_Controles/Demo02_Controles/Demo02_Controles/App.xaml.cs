using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Demo02_Controles
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new Paginas.PaginaDatos();
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
