using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace BanderasApp
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            //MainPage = new NavigationPage(new Paginas.PaginaJuego());
            MainPage = new AppShell();

            OSAppTheme t = Application.Current.RequestedTheme;

            Application.Current.RequestedThemeChanged += (s, a) =>
            {
                // Para detectar esto en Android requerimos ConfigChanges.UiMode en MainActivity (por defecto ya estaba esa opcion)
            };
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
