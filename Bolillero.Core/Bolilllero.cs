namespace Bolillero.Core;
public class Bolillero
{
    public List<int> Bolillas { get; set; }
    public List<int> Afuera { get; set; }
    public IJugada Jugada { get; set; }
    public Bolillero(int Bolillas, int Numeros, int Jugar, IJugada jugada)
    {
        this.Bolillas = new List<int>();
        this.Afuera = new List<int>();
        this.Jugada = jugada;


    }
    public bool Jugar(List<int> jugada)
    {
        for (int i = 0; i < jugada.Count; i++)
        {

        }
        return true;
    }
    public int SacarBolilla()
    {
        var bolilla = Jugada.ElegirBolilla(Bolillas);
    }
    public int MeterBolilla()
    {
        var bolilla =
    }
    public int JugarNVeces(List<int> JugarNVeces) { }





}
