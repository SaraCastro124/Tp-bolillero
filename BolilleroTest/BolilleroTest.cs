using BolilleroCore;

namespace BolilleroTest;

public class BolilleroTest
{
    public Bolillero bolillero {get; set;}
    public BolilleroTest() => bolillero = new Bolillero(10, new ElegirPrimera());

    [Fact]
    public void SacarBolilla()
    {
        var bolilla = bolillero.SacarBolilla();
        Assert.Equal()
    }
}