using System;
using System.Collections.Generic;
using System.Text;

namespace Demo06_Genericos_Async_Serializacion.Clases
{
    public class Profesor : Persona
    {
        public string Departamento { get; set; }
        public float Salario { get; set; }

        public Profesor(int id, string nom, string dep, float sal) : base(id, nom)
        {
            Departamento = dep;
            Salario = sal;
        }

        public Profesor() : base()
        {

        }
    }
}
