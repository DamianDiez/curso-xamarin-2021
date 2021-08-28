using System;

namespace Demo03_Lambda
{
    class Program
    {
        /*
        static bool EsNumeroPar(int x)
        {
            return (x % 2 == 0);
        }
        */
        static bool EsNumeroPar(int x) => (x % 2 == 0);

        static void Main(string[] args)
        {
            bool prueba = EsNumeroPar(7);
            Console.WriteLine(prueba);

            Func<string> delegado = () => "Hola";
            string mensaje = delegado.Invoke();
            Console.WriteLine(mensaje);

            Action<double, double> delegadoR = (x, y) =>
            {
                double formula = Math.Sqrt(x + y) - 5;
                Console.WriteLine(formula);
            };
            delegadoR.Invoke(8.1, 20.3);
        }
    }
}
