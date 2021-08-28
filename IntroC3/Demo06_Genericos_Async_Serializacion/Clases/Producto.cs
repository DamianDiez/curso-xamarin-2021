using System;
using System.Collections.Generic;
using System.Text;

namespace Demo06_Genericos_Async_Serializacion.Clases
{
    public class Producto
    {
        public string Nombre { get; set; }
        public float Precio { get; set; }

        public Producto(string nom, float pre)
        {
            Nombre = nom;
            Precio = pre;
        }
    }
}
