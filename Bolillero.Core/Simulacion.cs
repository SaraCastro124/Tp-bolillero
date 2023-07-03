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

        public async Task<long> SimularConHilosAsync(Bolillero bolillero, List<int> jugada, int cantidadSim, int cantidadHilos)
        {
            var tareasAsync = new Task<long>[cantidadHilos];
            for (int i = 0; i < cantidadHilos; i++)
            {
                var clon = bolillero.Clonar();
                tareasAsync[i] = Task<long>.Run(() => (long)clon.JugarNVeces(jugada, cantidadSim));
            }
            await Task<long>.WhenAll(tareasAsync);
            return tareasAsync.Sum(t => t.Result);
        }
        public async Task<long> SimularParallelAsync(Bolillero bolillero, List<int> jugada, int cantidadSim, int cantidadHilos)
        {
            long[] resultados = new long[cantidadHilos]; 

            await Task.Run(() =>
            Parallel.For(0,
                        cantidadHilos,
                        i => {
                                var clon = bolillero.Clonar();
                                resultados[i] = 
                                } 
                );
            );
            return resultados.Average();

        }

    }
}