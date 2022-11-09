// See https://aka.ms/new-console-template for more information

public class Evento
{
    public string titolo { get; set; }
    public DateTime data { get; set; }
    public int postiMassima { get; }
    public int posti { get; }

    public Evento (string Titolo, DateTime Data, int Posti)
    {
        Titolo = titolo;
        Data = data;
        Posti = posti;
    }

    public string TitoloSetter(string Titolo)
    {
        if (Titolo.Lenght <= 0)
    }
}
