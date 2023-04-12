namespace Bolillero.Core;
public class Bolillero
{
    public List<int> Bolillas { get; set; }
    public IJugada jugada { get; set; }
    public Bolillero(int Bolillas, int Jugar, IJugada jugada)
    {
        this.Bolillas = new List<int>();
        this.jugada = jugada;


    }
    public bool Jugar(List<int> Jugar)
    {
        for (int i = 0; i < Jugar.Count; i++)
        {
            SacarBolilla() = i
        }
    }
    public void SacarBolilla() { }
    public void MeterBolilla() { }
    public void JugarNVeces(List<int> JugarNVeces) { }





}
