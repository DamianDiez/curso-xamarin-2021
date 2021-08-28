using System;
using System.Linq;
using System.Collections.Generic;

namespace Demo05_Excepciones
{
    class Program
    {
        static void ImprimirUnDato(Producto producto)
            => Console.WriteLine($"{producto.Nombre}" +
                $"\t{producto.Categoria}" +
                $"\t{producto.Pais}" +
                $"\t{producto.Precio}" +
                $"\t{producto.Cantidad}");

        static void Imprimir(IEnumerable<Producto> lista)
        {
            foreach (var dato in lista)
            {
                ImprimirUnDato(dato);
            }

            Console.WriteLine();
        }

        static void Main(string[] args)
        {
            var productos = ServicioProducto.ObtenerDatos();

            try
            {
                Console.WriteLine("--- Única Tecnología ---");
                var tecnologia = productos.SingleOrDefault(x => x.Categoria == "Tecnologia");
                if (tecnologia != null)
                    ImprimirUnDato(tecnologia);
                Console.WriteLine();
            }
            catch (InvalidOperationException n)
            {
                Console.WriteLine("Más de un elemento encontrado.");
            }
            finally
            {
                Console.WriteLine("Siguiente consulta");
            }

            foreach (var p in productos)
            {
                try
                {
                    var indice = p.Precio / p.Cantidad;
                    Console.WriteLine($"Producto: {p.Nombre} Índice: {indice}");
                }
                catch (DivideByZeroException d)
                {
                    Console.WriteLine($"Producto: {p.Nombre} Índice: N/A");
                }
            }
        }
    }
}
