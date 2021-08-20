using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Demo0456_Interfaces_Arreglos_Colecciones.Clases;
using Demo0456_Interfaces_Arreglos_Colecciones.Interfaces;
using Demo0456_Interfaces_Arreglos_Colecciones.Servicios;

namespace Demo0456_Interfaces_Arreglos_Colecciones
{
    class Program
    {
        static void Imprimir(List<Empleado> lista)
        {
            foreach (var empleado in lista)
            {
                Console.WriteLine($"{empleado.Id}\t{empleado.Nombre}\t{empleado.Salario:C2}");
            }
        }

        static async Task Main(string[] args)
        {
            IDatos servicioA = new ServicioArchivo();
            List<Empleado> listaA = await servicioA.LeerDatos(@"Datos/Registro.txt");
            Console.WriteLine("Datos de Archivo");
            Imprimir(listaA);

            IDatos servicioI = new ServicioInternet();
            List<Empleado> listaI = await servicioI.LeerDatos("https://gist.githubusercontent.com/icebeam7/b8519292aa122a1e114e157246bf07b7/raw/88f070ddb964828926bb2b0861fd525480e6e16b/empleados.json");
            Console.WriteLine("\nDatos de Internet");
            Imprimir(listaI);

            Console.WriteLine("Presiona una tecla para finalizar");
            Console.ReadKey();
        }
    }
}
