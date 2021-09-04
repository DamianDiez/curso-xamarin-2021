using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

using BanderasApp.Clases;

namespace BanderasApp.Paginas
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PaginaDetalle : ContentPage
    {
        public PaginaDetalle(Pais p)
        {
            InitializeComponent();
            MostrarDatos(p);
        }

        void MostrarDatos(Pais p)
        {
            tarjetaPais.NombrePais = p.CountryName;
            tarjetaPais.Capital = p.Capital;
            tarjetaPais.Continente = p.ContinentName;
            tarjetaPais.Moneda = p.CurrencyCode;
            tarjetaPais.Poblacion = p.Population;

            string codigoPais = p.CountryCode.ToLower();
            string urlBandera = $"https://raw.githubusercontent.com/hjnilsson/country-flags/master/png250px/{codigoPais}.png";
            tarjetaPais.ImagenBandera = new UriImageSource
            {
                Uri = new Uri(urlBandera),
                CachingEnabled = true,
                CacheValidity = new TimeSpan(7, 0, 0, 0)
            };
        }

    }
}