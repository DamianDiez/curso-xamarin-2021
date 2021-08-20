using System;

namespace Demo02_Clases
{
    class Program
    {
        static void Main(string[] args)
        {
            char hayDescuento;
            float descuento;
            Producto p = new Producto();

            Console.WriteLine("¿Cuál es el nombre del producto?");
            p.Nombre = Console.ReadLine();

            Console.WriteLine("¿A qué categoría pertenece?");
            p.Categoria = Console.ReadLine();

            Console.WriteLine("¿Cuál es su precio?");
            p.Precio = float.Parse(Console.ReadLine());

            Console.WriteLine("¿Cuántos items hay del producto?");
            p.Stock = int.Parse(Console.ReadLine());

            Console.WriteLine("¿Quieres aplicar descuento (S/N)?");
            hayDescuento = char.ToLower(Console.ReadKey().KeyChar);

            if (hayDescuento == 's')
            {
                Console.WriteLine("Ingresa el porcentaje de descuento.");
                descuento = float.Parse(Console.ReadLine());

                p.AplicarDescuento(descuento);
            }

            p.Vender(10);
            Console.WriteLine("Se ha intentado vender 10 items del producto");

            Console.WriteLine($"Producto: {p.Nombre}");
            Console.WriteLine($"Categoría: {p.Categoria}");
            Console.WriteLine($"Precio: {p.Precio:C2}");
            Console.WriteLine($"Stock: {p.Stock}");

            Console.WriteLine("Presiona una tecla para finalizar");
            Console.ReadKey();
        }
    }
}
