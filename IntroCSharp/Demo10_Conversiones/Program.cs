using System;

namespace Demo10_Conversiones
{
    class Program
    {
        static void Main(string[] args)
        {
            int edad = 0;
            long año;
            Console.WriteLine("Ingresa tu edad");

            if (int.TryParse(Console.ReadLine(), out edad))
            {
                año = DateTime.Now.Year - edad;
                Console.WriteLine($"Naciste en el año {año}");
            }
            else
            {
                Console.WriteLine("El dato no es válido");
            }
        }
    }
}
