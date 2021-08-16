using System;

namespace Demo04_Control
{
    class Program
    {
        static void Main(string[] args)
        {
            int pasos;
            Console.WriteLine("¿Cuántos pasos caminaste el día de hoy?");
            pasos = int.Parse(Console.ReadLine());

            char tipo;
            Console.WriteLine("Presiona: \nn si eres niño(a) \na si eres adolescente \nd si eres adulto");
            tipo = char.ToLower(Console.ReadKey().KeyChar);

            switch (tipo)
            {
                case 'n':
                    if (pasos > 13000)
                        Console.WriteLine("Vas por buen camino");
                    else
                        Console.WriteLine("Se recomienda que camines más durante el día");
                    break;
                case 'a':
                    if (pasos > 11000)
                        Console.WriteLine("Vas por buen camino");
                    else
                        Console.WriteLine("Se recomienda que camines más durante el día");
                    break;
                case 'd':
                    if (pasos < 5000)
                        Console.WriteLine("Clasificación: persona sedentaria. Necesitas caminar más.");
                    else if (pasos < 7500)
                        Console.WriteLine("Clasificación: persona poco activa. Camina un poco más.");
                    else if (pasos < 10000)
                        Console.WriteLine("Clasificación: persona activa. Vas bien.");
                    else
                        Console.WriteLine("Clasificación: persona muy activa. Vas excelente, ¡sigue así!");
                    break;
                default:
                    Console.WriteLine("Esa opción no existe");
                    break;
            }

            Console.WriteLine("Presiona una tecla para finalizar");
            Console.ReadKey();
        }
    }
}
