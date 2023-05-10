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
        var victoria = bolillero.Jugar(jugada :new List<int> {0,1,2,3} );
        Assert.True(victoria);
    }

    [Fact]
    public void JugarPierde()
    {
        var falla = bolillero.Jugar(jugada :new List<int> {4,2,1});
        Assert.False(falla);
    }

    [Fact]
    public void JugarNVeces()
    {
        var gano = bolillero.JugarNVeces(jugada :new List<int> {0,1}, cantidad :1);
        Assert.Equal(1, gano);
    }
}