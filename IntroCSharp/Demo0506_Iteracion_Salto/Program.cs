using System;

namespace Demo0506_Iteracion_Salto
{
    class Program
    {
        static void Main(string[] args)
        {
            Random generador = new Random();
            int x = generador.Next(0, 1000);
            Console.WriteLine("Adivina el número entre 0 y 1000");

            int numero, contador = 1;

            do
            {
                Console.WriteLine($"Intento #{contador}. Escribe un número");
                numero = int.Parse(Console.ReadLine());

                if (numero == x)
                {
                    Console.WriteLine($"¡Felicidades! ¡Has adivinado el número en {contador} intentos!");
                    break;
                }

                if (numero < x)
                    Console.WriteLine($"¡Error! El número misterioso es más grande que {numero}");
                else
                    Console.WriteLine($"¡Error! El número misterioso es más pequeño que {numero}");

                contador++;
            } while (numero != x && contador < 10);

            if (numero != x)
                Console.WriteLine($"El número misterioso era el {x}");

            Console.WriteLine("Presiona una tecla para finalizar");
            Console.ReadKey();
        }
    }
}
