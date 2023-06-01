namespace BolilleroCore
{
    public class Simulacion
    {

        public long SimularSinHilos(Bolillero bolillero, List<int> jugada, int cantidadSim)
            => bolillero.JugarNVeces(jugada, cantidadSim);

        public long SimularConHilos(Bolillero bolillero, List<int> jugada, int cantidadSim, int cantidadHilos)
        {
            var tareas = new Task<long>[cantidadHilos];
            for (int i = 0; i < cantidadHilos; i++)
            {
                var clon = bolillero.Clonar();
                tareas[i] = Task<long>.Run(() => (long)clon.JugarNVeces(jugada, cantidadSim));
            }
            Task<long>.WaitAll(tareas);
            return tareas.Sum(t => t.Result);
        }

    }
}