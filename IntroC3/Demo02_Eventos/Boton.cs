using System;

namespace Demo02_Eventos
{
    public class Boton
    {
        private int contador;

        public event Action<int> OnClick;

        public void Click()
        {
            ++contador;
            OnClick?.Invoke(contador);
        }
    }
}
