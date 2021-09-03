using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace DemoEstructura
{
    public partial class App : Application
    {
        public static string Mensaje;

        public App()
        {
            InitializeComponent();
            MainPage = new PaginaInicial();
        }

        protected override void OnStart()
        {
            Mensaje = "Aplicacion iniciada";
        }

        protected override void OnSleep()
        {
            
        }

        protected override void OnResume()
        {
            Mensaje = "Aplicacion restaurada";
        }
    }
}
