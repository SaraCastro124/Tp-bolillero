namespace BolilleroCore
{
    public class Simulacion
    {

        public long SimularSinHilos(Bolillero bolillero, List<int> jugada, int cantidadSim)
            => bolillero.JugarNVeces(jugada, cantidadSim);

        public long SimularConHilos(Bolillero bolillero, List<int> jugada, int cantidadSim, int cantidadHilos)
        {
            var tarea = new Task<long>[cantidadHilos];
            for (int i = 0; i < cantidadHilos; i++)
            {
                var bolilleroClon = bolillero.Clonar();
            }

        }

    }
}