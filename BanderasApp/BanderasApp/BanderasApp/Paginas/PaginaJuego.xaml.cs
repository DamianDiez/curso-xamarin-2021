using System;
using System.Linq;
using System.Threading.Tasks;
using System.Collections.Generic;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

using BanderasApp.Clases;
using BanderasApp.Servicios;

namespace BanderasApp.Paginas
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PaginaJuego : ContentPage
    {
        public PaginaJuego()
        {
            InitializeComponent();
        }

        List<Pais> paises;
        int puntos = 10;
        int score = 0;
        int numOpciones = 4;

        Random generador;
        List<Pais> paisesOpcion;
        int respuestaCorrecta;
        int respuestaElegida;

        async Task CargarDatos()
        {
            indicador.IsRunning = true;
            generador = new Random();
            paises = await ServicioApi.ObtenerPaises();
            indicador.IsRunning = false;
        }

        void Limpiar()
        {
            radioOpcion1.IsChecked = false;
            radioOpcion2.IsChecked = false;
            radioOpcion3.IsChecked = false;
            radioOpcion4.IsChecked = false;

            respuestaElegida = -1;
        }

        void GenerarOpcion(RadioButton rb, string texto)
        {
            Label opcion = new Label()
            {
                Style = (Style)App.Current.Resources["labelNormal"],
                Text = texto
            };

            StackLayout stack = new StackLayout();
            stack.Children.Add(opcion);

            rb.Content = stack;
        }

        async Task GenerarPregunta()
        {
            indicador.IsRunning = true;

            await Task.Delay(3000);
            Limpiar();

            int numPaises = paises.Count;
            paisesOpcion = new List<Pais>();

            for (int i = 0; i < numOpciones; i++)
            {
                int indicePaisAleatorio = generador.Next(0, numPaises);
                Pais paisAleatorio = paises[indicePaisAleatorio];

                if (!paisesOpcion.Any(x => x.GeonameId == paisAleatorio.GeonameId))
                    paisesOpcion.Add(paisAleatorio);
                else
                    i--;
            }

            respuestaCorrecta = generador.Next(1, numOpciones + 1);
            
            string codigoPais = paisesOpcion[respuestaCorrecta - 1].CountryCode.ToLower();
            string urlBandera = $"https://raw.githubusercontent.com/hjnilsson/country-flags/master/png250px/{codigoPais}.png";
            imagenBandera.Source = new UriImageSource
            {
                Uri = new Uri(urlBandera),
                CachingEnabled = true,
                CacheValidity = new TimeSpan(7, 0, 0, 0)
            };

            GenerarOpcion(radioOpcion1, paisesOpcion[0].CountryName);
            GenerarOpcion(radioOpcion2, paisesOpcion[1].CountryName);
            GenerarOpcion(radioOpcion3, paisesOpcion[2].CountryName);
            GenerarOpcion(radioOpcion4, paisesOpcion[3].CountryName);

            indicador.IsRunning = false;
        }

        private void radioOpcion_CheckedChanged(object sender, CheckedChangedEventArgs e)
        {
            RadioButton rb = (RadioButton)sender;

            if (rb.IsChecked)
                respuestaElegida = int.Parse(rb.Value.ToString());
        }

        private async void btnResponder_Clicked(object sender, EventArgs e)
        {
            string mensaje;
            Pais paisPregunta = paisesOpcion[respuestaCorrecta - 1];
            labelRespuesta.Text = $"Respuesta: {paisPregunta.CountryName}";

            if (respuestaElegida == respuestaCorrecta)
            {
                score += puntos;
                mensaje = "Correcto =)";
            }
            else
            {
                score -= puntos / 2;
                mensaje = "Incorrecto =(";
            }

            labelScore.Text = $"Score: {score} puntos";
            await DisplayAlert("Resultado", mensaje, "OK");
            await Task.Delay(3000);

            await GenerarPregunta();
        }

        protected async override void OnAppearing()
        {
            base.OnAppearing();
            await CargarDatos();
            await GenerarPregunta();
        }
    }
}