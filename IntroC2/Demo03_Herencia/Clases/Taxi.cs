namespace Demo03_Herencia.Clases
{
    public class Taxi : Vehiculo
    {
        public bool EstaLibre { get; set; }

        public override void RecogerPasajero()
        {
            base.RecogerPasajero();
            EstaLibre = false;
        }

        public override void DespedirPasajero()
        {
            base.DespedirPasajero();
            Cobrar(200);
            EstaLibre = true;
        }
    }
}
