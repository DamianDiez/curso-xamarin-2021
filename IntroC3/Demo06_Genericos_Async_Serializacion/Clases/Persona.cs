using System;
using System.Collections.Generic;
using System.Text;

namespace Demo06_Genericos_Async_Serializacion.Clases
{
    public class Persona
    {
        public int Id { get; set; }
        public string Nombre { get; set; }

        public Persona(int id, string nom)
        {
            Id = id;
            Nombre = nom;
        }

        public Persona()
        {

        }
    }
}
