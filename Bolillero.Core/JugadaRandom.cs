namespace BolilleroCore;

public class JugadaRandom : IJugada
{

    public int ElegirBolillaAleatoria(List<int> bolillas)
    {
        Random random = new Random();
        int num = random.Next(bolillas.Count);
        return bolillas[num];

    }

}