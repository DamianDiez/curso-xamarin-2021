using System;

namespace Demo0203_Declaracion_Expresion
{
    class Program
    {
        static void Main(string[] args)
        {
            string nombre;
            int añoNacimiento, edad;
            int añoActual = DateTime.Now.Year;
            float salario, porcentaje;

            Console.WriteLine("¿Cómo te llamas?");
            nombre = Console.ReadLine();

            Console.WriteLine("¿En qué año naciste?");
            añoNacimiento = int.Parse(Console.ReadLine());

            Console.WriteLine("¿Cuál es tu salario mensual?");
            salario = float.Parse(Console.ReadLine());

            Console.WriteLine("¿Cuál es el porcentaje de incremento?");
            porcentaje = float.Parse(Console.ReadLine());

            edad = añoActual - añoNacimiento;
            salario = salario + (salario * porcentaje / 100);
            //salarioBase *= (1 + porcentaje / 100)

            Console.WriteLine($"Hola {nombre}, tu edad es {edad} años");
            Console.WriteLine($"Tu nuevo salario mensual es {salario:C2}");

            Console.WriteLine("Presiona una tecla para finalizar");
            Console.ReadKey();
        }
    }
}