using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Demo01_Paginas.Paginas
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PaginaLogin : ContentPage
    {
        public PaginaLogin()
        {
            InitializeComponent();
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            if (entryClave.Text == "123" && entryPassword.Text == "pass")
            {
                await DisplayAlert("Bienvenido", "Ingresando al sistema...", "OK");
                App.Current.MainPage = new NavigationPage(new PaginaProducto());

                //await Navigation.PushAsync(new PaginaProducto());
            }
            else
            {
                await DisplayAlert("Error", "Datos no válidos...", "OK");
            }
        }
    }
}