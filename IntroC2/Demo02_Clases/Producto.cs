using System;

namespace Demo02_Clases
{
    public class Producto
    {
        private int id;

        public string Nombre { get; set; }
        public string Categoria { get; set; }
        public float Precio { get; set; }

        private int stock;

        public int Stock
        {
            get { return stock; }
            set 
            { 
                if (value >= 0)
                    stock = value; 
            }
        }

        public Producto()
        {
            id = asignarID();
        }

        public Producto(string nombre, string categoria, float precio, int stock)
        {
            id = asignarID();
            Nombre = nombre;
            Categoria = categoria;
            Precio = precio;
            Stock = stock;
        }

        private int asignarID()
        {
            Random generador = new Random();
            return generador.Next(0, 1000);
        }

        public void AplicarDescuento(float descuento)
        {
            Precio *= (1 - descuento / 100);
        }

        public void Vender(int cantidad)
        {
            Stock -= cantidad;
        }
    }
}