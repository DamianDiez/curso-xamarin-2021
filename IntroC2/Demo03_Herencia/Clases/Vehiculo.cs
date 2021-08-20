namespace Demo03_Herencia.Clases
{
    public class Vehiculo
    {
        private string Matricula { get; set; }
        public string Modelo { get; set; }
        public float Ganancias { get; set; }

        protected void Cobrar(float monto)
        {
            Ganancias += monto;
        }

        public virtual void RecogerPasajero()
        { 

        }

        public virtual void DespedirPasajero()
        {

        }
    }
}
