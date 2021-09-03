using System;
using System.Net.Http;
using System.Threading.Tasks;
using System.Net.Http.Headers;
using System.Collections.Generic;

using Newtonsoft.Json;
using Xamarin.Essentials;

using BanderasApp.Clases;

namespace BanderasApp.Servicios
{
    public class ServicioApi
    {
        static string key = "icebeam";
        static string servicio = $"countryInfoJSON?username={key}";

        private static HttpClient CrearClienteHttp()
        {
            var cliente = new HttpClient();
            cliente.BaseAddress = new Uri("http://api.geonames.org/");
            cliente.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json"));
            return cliente;
        }

        private static HttpClient cliente = CrearClienteHttp();

        public async static Task<List<Pais>> ObtenerPaises()
        {
            if (Connectivity.NetworkAccess == NetworkAccess.Internet)
            {
                var respuesta = await cliente.GetAsync(servicio);

                if (respuesta.IsSuccessStatusCode)
                {
                    string json = await respuesta.Content.ReadAsStringAsync();
                    var geo = JsonConvert.DeserializeObject<GeoPais>(json);
                    return geo.Geonames;
                }
            }

            return new List<Pais>();
        }
    }
}
