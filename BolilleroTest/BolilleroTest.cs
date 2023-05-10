using BolilleroCore;

namespace BolilleroTest;

public class BolilleroTest
{
    public Bolillero bolillero { get; set; }
    public BolilleroTest() => bolillero = new Bolillero(10, new ElegirPrimera());

    [Fact]
    public void SacarBolilla()
    {
        Assert.Empty(bolillero.Afuera);
        var bolilla = bolillero.SacarBolilla();

        Assert.Single(bolillero.Afuera);
    }
    [Fact]
    public void MeterBolillas()
    {

        Assert.NotEmpty(bolillero.Bolillas);
        Assert.Empty(bolillero.Afuera);
        bolillero.SacarBolilla();
        Assert.Single(bolillero.Afuera);
        bolillero.MeterBolillas();
        Assert.Empty(bolillero.Afuera);



    }
    [Fact]
    public void Jugar()
    {
        var Victoria = bolillero.Jugar(jugada :new List<int> {0,1,2,3} )
        Assert.true(Victoria);
    }

    [Fact]
    public void Jugar()
    {
        var Falla = bolillero.Jugar(Jugada :new List<int> {4,2,1})
        Assert.false()
    }
}