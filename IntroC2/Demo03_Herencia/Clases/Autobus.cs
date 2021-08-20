namespace Demo03_Herencia.Clases
{
    public class Autobus : Vehiculo
    {
        public int Asientos { get; set; }

        private int asientosLibres;

        public int AsientosLibres
        {
            get { return asientosLibres; }
            set
            {
                if (value >= 0 && value <= Asientos)
                    asientosLibres = value;
            }
        }

        public Autobus(string modelo, int asientos)
        {
            Modelo = modelo;
            Asientos = asientos;
            AsientosLibres = asientos;
        }

        public override void RecogerPasajero()
        {
            base.RecogerPasajero();
            Cobrar(3.5f);
            AsientosLibres--;
        }

        public override void DespedirPasajero()
        {
            base.DespedirPasajero();
            AsientosLibres++;
        }
    }
}
