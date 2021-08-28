using System;
using System.Linq;
using System.Collections.Generic;

namespace Demo04_Linq
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

            Console.WriteLine("--- Productos ordenados por nombre ---");
            var productosOrdenadosNombre = productos.OrderBy(x => x.Nombre);
            Imprimir(productosOrdenadosNombre);

            Console.WriteLine("--- Productos ordenados por categoria y nombre ---");
            var productosOrdenadosCatNombre = productos.OrderBy(x => x.Categoria).ThenBy(x => x.Nombre);
            Imprimir(productosOrdenadosCatNombre);

            Console.WriteLine("--- Del más caro al más barato ---");
            var productosOrdenadosPrecio = productos.OrderByDescending(x => x.Precio);
            Imprimir(productosOrdenadosPrecio);

            Console.WriteLine("--- Productos de Tecnologia ---");
            var productosTecnologia = productos.Where(x => x.Categoria == "Tecnologia");
            Imprimir(productosTecnologia);

            Console.WriteLine("--- Los 3 productos más baratos ---");
            var productosBaratos = productos.OrderBy(x => x.Precio).Take(3);
            Imprimir(productosBaratos);

            Console.WriteLine("--- Productos en Existencia ---");
            var productosExistentes = productos.Where(x => x.Cantidad > 0);
            Imprimir(productosExistentes);

            Console.WriteLine("--- Primer Lacteo ---");
            var primerLacteo = productos.FirstOrDefault(x => x.Categoria == "Lacteos");
            if (primerLacteo != null)
                ImprimirUnDato(primerLacteo);
            Console.WriteLine();

            Console.WriteLine("--- Única Bebida ---");
            var bebida = productos.SingleOrDefault(x => x.Categoria == "Bebida");
            if (bebida != null)
                ImprimirUnDato(bebida);
            Console.WriteLine();

            Console.WriteLine("--- ¿Existe algun producto de Tecnologia menor a 500? ---");
            var hayTecnologiaBarata = productos.Any(x => x.Categoria == "Tecnologia" && x.Precio < 500);
            var respuestaTB = hayTecnologiaBarata ? "Sí" : "No";
            Console.WriteLine(respuestaTB);
            Console.WriteLine();

            Console.WriteLine("--- Funciones de agregación ---");
            var menorPrecio = productos.Min(x => x.Precio);
            var mayorPrecio = productos.Max(x => x.Precio);
            var precioPromedio = productos.Average(x => x.Precio);
            var inventario = productos.Sum(x => x.Cantidad);
            Console.WriteLine($"Menor precio: {menorPrecio}");
            Console.WriteLine($"Mayor precio: {mayorPrecio}");
            Console.WriteLine($"Precio promedio: {precioPromedio}");
            Console.WriteLine($"Inventario: {inventario}");
            Console.WriteLine();

            int cantidadPorPagina = 3;
            int paginas = (int)Math.Ceiling((float)productos.Count / cantidadPorPagina);

            for (int pag = 0; pag < paginas; pag++)
            {
                var productosPagina = productos.Skip(pag * cantidadPorPagina)
                                               .Take(cantidadPorPagina);

                Console.WriteLine($"--- Pagina {pag + 1}---");
                Imprimir(productosPagina);
            }
        }
    }
}
