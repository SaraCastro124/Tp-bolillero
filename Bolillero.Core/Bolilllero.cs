namespace Bolillero.Core;
public class Bolillero
{
    public List<int> Bolillas { get; set; }
    public int Jugar { get; set; }
    public IJugada jugada { get; set; }
    public Bolillero(int Bolillas, int Jugar, IJugada jugada)
    {
        this.Jugar = Jugar;
        this.Bolillas = ;
        this.jugada = jugada;


    }
    public void SacarBolilla() { }
    public void JugarNVeces() { }





}
