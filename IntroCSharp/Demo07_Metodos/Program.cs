using System;

namespace Demo07_Metodos
{
    class Program
    {
        private static float calcularPerimetro(float ancho, float alto)
        {
            float perimetro = 2 * (ancho + alto);
            return perimetro;
        }

        private static float calcularArea(float ancho, float alto)
        {
            float area = ancho * alto;
            return area;
        }

        static void Main(string[] args)
        {
            float ancho, alto, perimetro, area;
            Console.WriteLine("Datos del rectángulo");

            Console.WriteLine("¿Cuál es el valor del ancho?");
            ancho = float.Parse(Console.ReadLine());

            Console.WriteLine("¿Cuál es el valor del alto?");
            alto = float.Parse(Console.ReadLine());

            perimetro = calcularPerimetro(ancho, alto);
            Console.WriteLine($"Su perímetro es {perimetro} unidades");

            area = calcularArea(ancho, alto);
            Console.WriteLine($"Su área es {area} unidades cuadradas");

            Console.WriteLine("Presiona una tecla para finalizar");
            Console.ReadKey();
        }
    }
}
