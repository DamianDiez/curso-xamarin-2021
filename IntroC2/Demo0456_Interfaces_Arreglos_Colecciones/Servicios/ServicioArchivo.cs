using System.IO;
using System.Threading.Tasks;
using System.Collections.Generic;
using Demo0456_Interfaces_Arreglos_Colecciones.Clases;
using Demo0456_Interfaces_Arreglos_Colecciones.Interfaces;

namespace Demo0456_Interfaces_Arreglos_Colecciones.Servicios
{
    public class ServicioArchivo : IDatos
    {
        public async Task<List<Empleado>> LeerDatos(string ruta)
        {
            List<Empleado> listaEmpleados = new List<Empleado>();

            string[] registros = await File.ReadAllLinesAsync(ruta);

            foreach (string reg in registros)
            {
                string[] dato = reg.Split(',');

                Empleado empleado = new Empleado()
                {
                    Id = int.Parse(dato[0]),
                    Nombre = dato[1],
                    Salario = float.Parse(dato[2])
                };

                listaEmpleados.Add(empleado); 
            }

            return listaEmpleados;
        }
    }
}
