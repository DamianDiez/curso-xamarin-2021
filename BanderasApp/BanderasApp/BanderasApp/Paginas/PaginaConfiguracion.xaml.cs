using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace BanderasApp.Paginas
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PaginaConfiguracion : ContentPage
    {
        public PaginaConfiguracion()
        {
            InitializeComponent();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();

            var pts = Preferences.Get("puntos", 10);
            stepPuntos.Value = pts;
        }

        private async void btnGuardar_Clicked(object sender, EventArgs e)
        {
            var pts = (int)stepPuntos.Value;
            Preferences.Set("puntos", pts);
            await DisplayAlert("Información", "Datos guardados exitosamente", "OK");
        }
    }
}