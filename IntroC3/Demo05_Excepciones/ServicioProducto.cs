using System;
using System.Collections.Generic;
using System.Text;

namespace Demo05_Excepciones
{
    public static class ServicioProducto
    {
        public static List<Producto> ObtenerDatos() =>
            new List<Producto>()
            {
                new Producto() { Nombre = "Cerveza", Categoria = "Bebida", Pais = "Alemania", Precio = 100, Cantidad = 10 },
                new Producto() { Nombre = "Camara", Categoria = "Tecnologia", Pais = "Alemania", Precio = 300, Cantidad = 0 },
                new Producto() { Nombre = "Pizza", Categoria = "Alimentos", Pais = "Italia", Precio = 512, Cantidad = 0 },
                new Producto() { Nombre = "Queso", Categoria = "Lacteos", Pais = "Italia", Precio = 891, Cantidad = 6 },
                new Producto() { Nombre = "Computadora", Categoria = "Tecnologia", Pais = "Estados Unidos", Precio = 1023, Cantidad = 20 },
                new Producto() { Nombre = "Playera", Categoria = "Ropa", Pais = "Mexico", Precio = 200, Cantidad = 20 },
                new Producto() { Nombre = "Leche", Categoria = "Lacteos", Pais = "Mexico", Precio = 36, Cantidad = 50 },
            };
    }
}
