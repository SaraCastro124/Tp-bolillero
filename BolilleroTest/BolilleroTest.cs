using BolilleroCore;

namespace BolilleroTest;

public class BolilleroTest
{
    public Bolillero bolillero { get; set; }
    public BolilleroTest() => bolillero = new Bolillero(10, new ElegirPrimera());

    [Fact]
    public void SacarBolilla()
    {
        var bolilla = bolillero.SacarBolilla();
        Assert.Equal(0, bolilla);
        Assert.Equal(9, bolillero.Bolillas.Count);
        Assert.Single(bolillero.Afuera);
    }
    [Fact]
    public void MeterBolillas()
    {
        Assert.Equal(0, bolilla);
        Assert.Single(bolillero.Afuera);
        Assert.Equal(9, bolillero.Bolillas.Count);
    }
    [Fact]
    public void
}