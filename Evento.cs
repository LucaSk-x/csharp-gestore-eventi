// See https://aka.ms/new-console-template for more information

public class Evento
{
    private string _titolo;
    private DateTime _data;
    public int PostiMax { get; }
    public int PostiPrenotati { get; private set; }

    public string Titolo
    {
        get
        {
            return _titolo;
        }

        set
        {
            if (value == null || value == "")
            {
                throw new GestoreEventiExpection("Il formato del titolo non è valido");
            }
            _titolo = value;
        }
    }

    public DateTime Data
    {
        get 
        { 
            return _data;
        }

        set 
        {
            if (_data >= DateTime.Now || _data == null)
                throw new GestoreEventiExpection("La data inserita non è valida");
                _data = value;
        }
    }

    public Evento(string _titolo, DateTime _data, int postiMax, int postiPrenotati)
    {
        Titolo = _titolo;
        Data = _data;
        if (postiMax > 0)
        {
            PostiMax = postiMax;
        }
        PostiPrenotati = 0;
    }

    public int prenotaPosti(int inputPrenota)
    {
        if ((PostiMax - PostiPrenotati) > inputPrenota)
        {
            PostiPrenotati =+ inputPrenota;
        }
        return PostiPrenotati;
    }

    public int postiDisponibili()
    {
        if (PostiMax > PostiPrenotati)
        {
            return PostiMax - PostiPrenotati;
        }
        else
            return 0;
    }

    public int disdiciPosti(int inputDisdici)
    {
        if((PostiPrenotati - inputDisdici) >= 0)
        {
            PostiPrenotati = PostiPrenotati - inputDisdici;
            return PostiPrenotati;
        }
        else
        {
            return 0;
        }
    }
}





