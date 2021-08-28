using System;
using System.Collections.Generic;
using System.Text;

namespace Demo06_Genericos_Async_Serializacion.Clases
{
    public class Alumno : Persona
    {
        public string Carrera { get; set; }
        public int Calificacion { get; set; }

        public Alumno(int id, string nom, string car, int cal) : base(id, nom)
        {
            Carrera = car;
            Calificacion = cal;
        }

        public Alumno() : base()
        {

        }
    }
}
