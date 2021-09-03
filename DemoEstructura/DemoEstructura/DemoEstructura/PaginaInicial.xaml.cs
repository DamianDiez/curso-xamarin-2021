using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace DemoEstructura
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PaginaInicial : ContentPage
    {
        public PaginaInicial()
        {
            InitializeComponent();
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            await DisplayAlert("Mensaje", App.Mensaje, "OK");
        }

        private void btnAgregarHora_Clicked(object sender, EventArgs e)
        {
            Label texto = new Label();
            texto.Text = DateTime.Now.TimeOfDay.ToString();
            texto.TextColor = Color.Blue;
            texto.FontSize = 15;

            stack.Children.Add(texto);
        }

        private void btnLimpiar_Clicked(object sender, EventArgs e)
        {
            // coleccion de labels agregados
            var textos = stack.Children.Where(x => x is Label).ToList();

            foreach (var item in textos)
            {
                stack.Children.Remove(item);
            }

        }
    }
}