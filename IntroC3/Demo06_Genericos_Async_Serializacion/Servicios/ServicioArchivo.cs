using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using Demo06_Genericos_Async_Serializacion.Clases;

namespace Demo06_Genericos_Async_Serializacion.Servicios
{
    public class ServicioArchivo<T> where T : Persona
    {
        public async Task Guardar(string archivo, List<T> datos)
        {
            string json = JsonSerializer.Serialize(datos);
            await File.WriteAllTextAsync(archivo, json);
        }

        public async Task<List<T>> Leer(string archivo)
        {
            string json = await File.ReadAllTextAsync(archivo);
            List<T> datos = JsonSerializer.Deserialize<List<T>>(json);
            return datos;
        }
    }
}
