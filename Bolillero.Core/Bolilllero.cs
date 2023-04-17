namespace Bolillero.Core;
public class Bolillero
{
    public List<int> Bolillas { get; set; }
    public List<int> Afuera { get; set; }
    public IJugada jugada { get; set; }
    public Bolillero(int Bolillas, int Numeros, int Jugar, IJugada jugada)
    {
        this.Bolillas = new List<int>();
        this.Afuera = new List<int>();
        this.jugada = jugada;


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
        jugada.ElegirBolilla()
    }
    public void MeterBolilla() { }
    public void JugarNVeces(List<int> JugarNVeces) { }





}
