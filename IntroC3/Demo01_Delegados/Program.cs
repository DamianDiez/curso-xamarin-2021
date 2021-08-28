using System;

namespace Demo01_Delegados
{
    class Program
    {
        static double Sumar(double a, double b)
        {
            Console.WriteLine("Estamos sumando");
            return a + b;
        }

        static double Restar(double a, double b)
        {
            Console.WriteLine("Estamos restando");
            return a - b;
        }

        static double Multiplicar(double a, double b)
        {
            Console.WriteLine("Estamos multiplicando");
            return a * b;
        }

        static double Dividir(double a, double b)
        {
            Console.WriteLine("Estamos dividiendo");
            return a / b;
        }

        static double ObtenerResiduo(double a, double b)
        {
            Console.WriteLine("Estamos obteniendo el residuo");
            return a % b;
        }

        static double ElevarPotencia(double a, double b)
        {
            Console.WriteLine("Estamos elevando a potencia");
            return Math.Pow(a, b);
        }

        static void ImprimirMensaje(string mensaje)
        {
            Console.WriteLine(mensaje);
        }

        delegate double DelegadoCalculadora(double x, double y);

        static void Main(string[] args)
        {
            double valor1 = 4.3, valor2 = 2.7;

            DelegadoCalculadora delegado = Sumar;
            double resultado = delegado.Invoke(valor1, valor2);
            Console.WriteLine(resultado);

            delegado = null;
            delegado = Multiplicar;
            resultado = delegado.Invoke(valor1, valor2);
            Console.WriteLine(resultado);

            delegado += ObtenerResiduo;
            resultado = delegado.Invoke(valor1, valor2);
            Console.WriteLine(resultado);

            //delegado += ImprimirMensaje;
        }
    }
}
