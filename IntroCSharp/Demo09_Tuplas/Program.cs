using System;

namespace Demo09_Tuplas
{
    class Program
    {
        private static Tuple<int, int, double> RealizarOperaciones(int a, int b)
        {
            int suma = a + b;
            int multiplicacion = a * b;
            double potencia = Math.Pow(a, b);

            return Tuple.Create(suma, multiplicacion, potencia);
        }

        static void Main(string[] args)
        {
            int a = 4, b = 7;

            var operaciones = RealizarOperaciones(a, b);
            Console.WriteLine($"La suma de {a} + {b} es {operaciones.Item1}");
            Console.WriteLine($"La multiplicación de {a} * {b} es {operaciones.Item2}");
            Console.WriteLine($"{a} elevado a la potencia {b} es {operaciones.Item3}");

            Console.WriteLine("Presiona una tecla para finalizar");
            Console.ReadKey();
        }
    }
}
