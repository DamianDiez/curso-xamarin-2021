using System;
using Demo03_Herencia.Clases;

namespace Demo03_Herencia
{
    class Program
    {
        static void Main(string[] args)
        {
            Taxi t = new Taxi();
            t.Modelo = "Sedan";
            t.RecogerPasajero();
            Console.WriteLine($"¿El taxi está libre? {t.EstaLibre}");
            t.DespedirPasajero();
            Console.WriteLine($"Ganancias del taxi {t.Ganancias}");

            Autobus a = new Autobus("Mercedes-Benz", 30);
            a.RecogerPasajero();
            a.RecogerPasajero();
            a.RecogerPasajero();
            a.DespedirPasajero();
            a.RecogerPasajero();
            a.DespedirPasajero();
            a.RecogerPasajero();
            Console.WriteLine($"Asientos disponibles del autobús {a.AsientosLibres}");
            Console.WriteLine($"Ganancias del autobús {a.Ganancias}");

            Console.WriteLine("Presiona una tecla para finalizar");
            Console.ReadKey();
        }
    }
}
