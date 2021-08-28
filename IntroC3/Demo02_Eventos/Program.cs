using System;

namespace Demo02_Eventos
{
    class Program
    {
        private static void Boton_OnClick(int count)
        {
            Console.WriteLine($"Has presionado el botón {count} veces");
        }

        static void Main(string[] args)
        {
            Boton b = new Boton();
            b.OnClick += Boton_OnClick;

            b.Click();
            b.Click();

            //b.OnClick = null;
            //b.OnClick?.Invoke(9);
        }
    }
}
