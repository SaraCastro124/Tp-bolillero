namespace BolilleroCore
{
    public class Simulacion
    {

        public long SimularSinHilos(Bolillero bolillero, List<int> jugada, int cantidadSim)
            => bolillero.JugarNVeces(jugada, cantidadSim);

        public long SimularConHilos(Bolillero bolillero, List<int> jugada, int cantidadSim, int cantidadHilos)
            => bolillero.JugarNVeces();
    }
}