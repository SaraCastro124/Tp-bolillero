using BolilleroCore;

namespace BolilleroTest;

public class SimulacionTest
{
    private Bolillero _bolillero;
    public Simulacion Simulacion { get; set; }
    public List<int> _jugada;
    private int _cantidadSim;
    private int _hilos;

    public SimulacionTest()
    {
        this._bolillero = new Bolillero(10, new ElegirPrimera());
        this.Simulacion = new Simulacion();
        _jugada = new List<int>() { 0 };
        _cantidadSim = 1;
        _hilos = 2;
    }

    [Fact]
    public void SimularSinHilosTest()
    {
        var ganadas = Simulacion.SimularSinHilos(_bolillero, _jugada, _hilos);
        Assert.Equal<long>(1, ganadas);
    }

    [Fact]

    public void SimularConHilos()
    {
        var gana = Simulacion.SimularConHilos(_bolillero, _jugada, _cantidadSim, _hilos);
        Assert.Equal(_hilos, gana);
    }

    [Fact]
    public async Task SimularConHilosAsync()
    {
        var ganaAsync = await Simulacion.SimularConHilosAsync(_bolillero, _jugada, _cantidadSim, _hilos);
        Assert.Equal(_hilos, ganaAsync);
    }
    
    [Fact]
    public async Task SimularParallelAsync()
    {
        var ParallelAsync = await Simulacion.SimularParallelAsync(_bolillero, _jugada, _cantidadSim, _hilos);
        Assert.Equal(_hilos, ParallelAsync);
    }

}