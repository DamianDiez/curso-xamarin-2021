using System;

namespace Demo08_Nulos
{
    class Program
    {
        static void Main(string[] args)
        {
            int? numero = null;

            int b = numero ?? 10;
            Console.WriteLine($"El valor de b es {b}");

            numero = 20;
            if (numero.HasValue)
                Console.WriteLine($"El valor de número es {numero.Value}");
            else
                Console.WriteLine($"El valor de número es NULL");

            Console.WriteLine("Presiona una tecla para finalizar");
            Console.ReadKey();
        }
    }
}
