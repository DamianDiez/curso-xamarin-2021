using System;
using System.Net;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;
using System.Collections.Generic;

using Demo0456_Interfaces_Arreglos_Colecciones.Clases;
using Demo0456_Interfaces_Arreglos_Colecciones.Interfaces;

namespace Demo0456_Interfaces_Arreglos_Colecciones.Servicios
{
    public class ServicioInternet : IDatos
    {
        public async Task<List<Empleado>> LeerDatos(string ruta)
        {
            using (var cliente = new HttpClient())
            {
                using (var respuesta = await cliente.GetAsync(ruta))
                {
                    if (respuesta.IsSuccessStatusCode)
                    {
                        var contenido = await respuesta.Content.ReadAsStreamAsync();
                        var lista = await JsonSerializer.DeserializeAsync<List<Empleado>>(contenido);
                        return lista;
                    }
                }
            }

            return new List<Empleado>();
        }
    }
}
