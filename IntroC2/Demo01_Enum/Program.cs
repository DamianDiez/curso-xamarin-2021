using System;

namespace Demo01_Enum
{
    class Program
    {
        static void Main(string[] args)
        {
            TipoPersona tipo;
            int dato, descuento = 0;

            Console.WriteLine("Escribe el número que representa tu caso.");
            Console.WriteLine("1) Profesor \t2) Estudiante \t3) Egresado");
            dato = int.Parse(Console.ReadLine());

            tipo = (TipoPersona)dato;

            switch (tipo)
            {
                case TipoPersona.Profesor:
                    descuento = 20;
                    break;
                case TipoPersona.Estudiante:
                    descuento = 50;
                    break;
                case TipoPersona.Egresado:
                    descuento = 40;
                    break;
                default:
                    break;
            }

            Console.WriteLine($"Te correspone un {descuento}% de descuento");

            Console.WriteLine("Presiona una tecla para finalizar");
            Console.ReadKey();
        }
    }
}
