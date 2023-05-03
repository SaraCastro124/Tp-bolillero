namespace BolilleroCore;
public class Bolillero
{
    public List<int> Bolillas { get; set; }
    public List<int> Afuera { get; set; }
    public IJugada Jugada { get; set; }
    public Bolillero(int Bolillas, IJugada jugada)
    {
        this.Bolillas = new List<int>();
        this.Afuera = new List<int>();
        this.Jugada = jugada;
        CrearBolillas(Bolillas);
    }

    private void CrearBolillas(int cantidad)
    {
        for (int i = 0; i < cantidad; i++)
            Bolillas.Add(i);
    }
    public bool Jugar(List<int> jugada)
    {
        for (int i = 0; i < jugada.Count; i++)
        {
            var bolilla = SacarBolilla();
            if (bolilla != jugada[i])
                return false;
        }
        return true;
    }
    public int SacarBolilla()
    {
        var bolilla = Jugada.ElegirBolillaAleatoria(Bolillas);
        Bolillas.Remove(bolilla);
        Afuera.Add(bolilla);
        return bolilla;
    }
    public void MeterBolillas()
    {
        Bolillas.AddRange(Afuera);
        Afuera.Clear();
    }
    public int JugarNVeces(List<int> jugada, int cantidad)
    {
        int ganadas = 0;
        for (int i = 0; i < cantidad; i++)
        {
            MeterBolillas();
            if (Jugar(jugada))
            {
                ganadas++;
            }
        }
        return ganadas;


    }





}
